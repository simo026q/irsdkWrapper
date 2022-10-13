using System;
using System.Threading;
using irsdkWrapper.Models.Telemetry;
using irsdkWrapper.Models.Session;
using irsdkSharp;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Models.Data;
using irsdkSharp.Serialization.Models.Session;
using Microsoft.Extensions.Logging;

namespace irsdkWrapper
{
    public class SdkWrapper : IDisposable
    {
        #region Constants
        public const int DefaultUpdateFrequency = 10;
        public const int MaxUpdateFrequency = 60;
        #endregion

        #region Fields
        private int _updateFrequency = DefaultUpdateFrequency;

        private CancellationTokenSource? _dataLoopCancellationSource;

        private readonly ILogger? _logger;

        private TelemetryData? _telemetry;
        private SessionInfo? _sessionInfo;

        protected IRacingSDK _sdk;
        #endregion

        #region Properties
        /// <summary>
        /// Updates per second (1-60)
        /// </summary>
        public int UpdateFrequency
        {
            get
            {
                return _updateFrequency;
            }
            set
            {
                if (value > 0 && value <= MaxUpdateFrequency)
                {
                    _updateFrequency = value;
                }
                else throw new ArgumentOutOfRangeException($"The UpdateFrequency must be between 1 and {MaxUpdateFrequency}");
            }
        }

        /// <summary>
        /// Update delay in miliseconds based on the update frequency
        /// </summary>
        public int WaitDelay => (int)Math.Round(1000 / (double)UpdateFrequency);

        /// <summary>
        /// If the data loop has been started
        /// </summary>
        public bool IsStarted => _dataLoopCancellationSource != null;

        /// <summary>
        /// If the Sim is connected and started
        /// </summary>
        public bool IsConnected => SdkIsConnected && IsStarted;

        /// <summary>
        /// If playing a replay - fetched from telemetry
        /// </summary>
        public bool IsReplay => Telemetry?.Session.IsReplayPlaying ?? false;

        /// <summary>
        /// SDK connection status
        /// </summary>
        public bool SdkIsConnected => _sdk.IsConnected();

        /// <summary>
        /// The session info from the last update
        /// </summary>
        public SessionInfo? SessionInfo => _sessionInfo;

        /// <summary>
        /// The telemetry from the last update
        /// </summary>
        public TelemetryData? Telemetry => _telemetry;
        #endregion

        #region Events
        public delegate void TelemetryUpdateEvent(object sender, TelemetryData e);

        public delegate void SessionInfoUpdateEvent(object sender, SessionInfo e);

        public event TelemetryUpdateEvent? TelemetryUpdated;

        public event SessionInfoUpdateEvent? SessionInfoUpdated;

        public event EventHandler? Connected;

        public event EventHandler? Disconnected;
        #endregion

        #region Contructor
        public SdkWrapper()
        {
            _sdk = new IRacingSDK();
            _sdk.OnConnected += OnSdkConnected;
            _sdk.OnDisconnected += OnSdkDisconnected;
        }

        public SdkWrapper(ILogger logger) : this() 
        {
            _logger = logger;
        }

        public SdkWrapper(bool autoStart, int updateFrequency = DefaultUpdateFrequency) : this()
        {
            if (autoStart) Start(updateFrequency);
        }
        #endregion

        #region Methods
        public void Start(bool restart = false)
        {
            if (restart) Stop();

            if (!IsStarted)
            {
                _dataLoopCancellationSource = new CancellationTokenSource();

                _logger?.LogInformation("Started SdkWrapper - waiting for a connection...");
            }
            else _logger?.LogWarning("SdkWrapper was already started.");
        }

        public void Start(int updateFrequency)
        {
            UpdateFrequency = updateFrequency;
            Start();
        }

        public void Stop()
        {
            _dataLoopCancellationSource?.Cancel(true);
            _dataLoopCancellationSource = null;

            _sessionInfo = null;
            _telemetry = null;

            _logger?.LogInformation("Stopped SdkWrapper.");
        }

        public void Dispose()
        {
            Stop();
        }

        private void Loop(CancellationToken cancellationToken)
        {
            int lastSessionUpdate = -1;

            while (!cancellationToken.IsCancellationRequested)
            {
                if (!SdkIsConnected) break;

                // Update telemetry
                IRacingDataModel sdkTelemetry = _sdk.GetSerializedData();

                if (_telemetry != null) _telemetry.Update(sdkTelemetry);
                else _telemetry = new TelemetryData(sdkTelemetry);
                
                _logger?.LogTrace("Updated telemetry.");
                TelemetryUpdated?.Invoke(this, _telemetry);

                // Update session info
                int newUpdate = _sdk.Header.SessionInfoUpdate;
                if (newUpdate != lastSessionUpdate)
                {
                    lastSessionUpdate = newUpdate;
                    IRacingSessionModel sdkSessionInfo = _sdk.GetSerializedSessionInfo();
                    _sessionInfo = new SessionInfo(sdkSessionInfo);

                    _logger?.LogTrace($"Updated session info. (id: {lastSessionUpdate})");
                    SessionInfoUpdated?.Invoke(this, _sessionInfo);
                }

                // Update delay
                if (!cancellationToken.IsCancellationRequested)
                {
                    Thread.Sleep(WaitDelay);
                }
            }
        }

        private void OnSdkConnected()
        {
            if (IsStarted)
            {
                _logger?.LogInformation("SdkWrapper connected to iRacing.");
                Connected?.Invoke(this, EventArgs.Empty);

                var cancellationToken = _dataLoopCancellationSource.Token;
                Task.Run(() => Loop(cancellationToken), cancellationToken);
            }
            else _logger?.LogWarning("SdkWrapper connected to iRacing but is not started yet.");
        }

        private void OnSdkDisconnected()
        {
            _logger?.LogInformation("SdkWrapper disconnected from iRacing.");

            Disconnected?.Invoke(this, EventArgs.Empty);

            Stop();
        }
        #endregion
    }
}
