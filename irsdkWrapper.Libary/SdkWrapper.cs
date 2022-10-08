using System;
using System.Threading;
using irsdkWrapper.Models.Telemetry;
using irsdkSharp;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Models.Data;
using irsdkSharp.Serialization.Models.Session;

namespace irsdkWrapper
{
    public class SdkWrapper
    {
        #region Constants
        public const int DefaultUpdateFrequency = 10;
        public const int MaxUpdateFrequency = 360;
        #endregion

        #region Fields
        private int _updateFrequency = DefaultUpdateFrequency;
        private int _lastSessionUpdate = -1;
        private bool _connectedOnLastUpdate = false;

        protected IRacingSDK _sdk;

        private TelemetryData? _telemetry;
        #endregion

        #region Properties
        /// <summary>
        /// The delay between a connection check when the sim is not connected
        /// </summary>
        public int CheckConnectionDelay { get; set; } = 5000;

        /// <summary>
        /// Updates per second (1-360)
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
        /// If the sim has been started
        /// </summary>
        public bool IsStarted { get; private set; } = false;

        /// <summary>
        /// If the Sim is connected and started
        /// </summary>
        public bool IsConnected => SdkIsConnected && IsStarted;

        /// <summary>
        /// If playing a replay - fetched from telemetry
        /// </summary>
        public bool IsReplay => (IsConnected && Telemetry != null) ? Telemetry.Session.IsReplayPlaying : false;

        /// <summary>
        /// SDK connection status
        /// </summary>
        public bool SdkIsConnected => _sdk.IsConnected();

        /// <summary>
        /// The session info from the last update
        /// </summary>
        public IRacingSessionModel? SessionInfo { get; private set; }

        /// <summary>
        /// The telemetry from the last update
        /// </summary>
        public TelemetryData? Telemetry => _telemetry;
        #endregion

        #region Events
        public delegate void TelemetryUpdateEvent(object sender, TelemetryData e);

        public delegate void SessionInfoUpdateEvent(object sender, IRacingSessionModel e);

        public event TelemetryUpdateEvent? TelemetryUpdated;

        public event SessionInfoUpdateEvent? SessionInfoUpdated;

        public event EventHandler? Connected;

        public event EventHandler? Disconnected;
        #endregion

        #region Contructor
        public SdkWrapper(bool autoStart = false, int updateFrequency = DefaultUpdateFrequency)
        {
            _sdk = new IRacingSDK();

            Reset();

            if (autoStart) Start(updateFrequency);
        }
        #endregion

        #region Methods
        public void Start(int updateFrequency = DefaultUpdateFrequency)
        {
            if (!IsStarted)
            {
                UpdateFrequency = updateFrequency;
                IsStarted = true;
                Loop();
            }
        }

        public void Stop()
        {
            IsStarted = false;
            Reset();
        }

        private void Reset()
        {
            SessionInfo = null;
            _telemetry = null;
        }

        private async void Loop()
        {
            while (IsStarted)
            {
                if (SdkIsConnected)
                {
                    if (!_connectedOnLastUpdate) Connected?.Invoke(this, EventArgs.Empty);

                    // Update telemetry
                    IRacingDataModel sdkTelemetry = IRacingSDKExtensions.GetSerializedData(_sdk);
                    if (_telemetry != null)
                    {
                        _telemetry.Update(sdkTelemetry);
                    }
                    else
                    {
                        _telemetry = new TelemetryData(sdkTelemetry);
                    }
                    TelemetryUpdated?.Invoke(this, _telemetry);

                    // Update session info
                    int newUpdate = _sdk.Header.SessionInfoUpdate;
                    if (newUpdate != _lastSessionUpdate)
                    {
                        _lastSessionUpdate = newUpdate;
                        IRacingSessionModel session = IRacingSDKExtensions.GetSerializedSessionInfo(_sdk);
                        SessionInfo = session;
                        SessionInfoUpdated?.Invoke(this, SessionInfo);
                    }

                    // Update delay
                    await Task.Delay(WaitDelay);
                }
                else
                {
                    if (_connectedOnLastUpdate) Disconnected?.Invoke(this, EventArgs.Empty);
                    await Task.Delay(CheckConnectionDelay);
                }
            }
        }
        #endregion
    }
}
