using System;
using irsdkSharp;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Models.Data;
using irsdkSharp.Serialization.Models.Session;

namespace irsdkWrapper
{
    public class SdkWrapper
    {
        #region Fields
        protected IRacingSDK _sdk;
        #endregion

        #region Properties
        /// <summary>
        /// The delay between a connection check when the sim is not connected
        /// </summary>
        public const int CheckConnectionDelay = 1000;

        /// <summary>
        /// Updates per second (1-60)
        /// </summary>
        public int UpdateFrequency
        {
            get
            {
                return UpdateFrequency;
            }
            set
            {
                if (value > 0 && value <= 60)
                {
                    UpdateFrequency = value;
                }
                else UpdateFrequency = 10;
            }
        }

        /// <summary>
        /// Update delay in miliseconds based on the update frequency
        /// </summary>
        public int UpdateDelay => (int)Math.Round(1000 / (double)UpdateFrequency);

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
        public bool IsReplay => (IsConnected && Telemetry != null) ? Telemetry.Data.IsReplayPlaying : false;

        /// <summary>
        /// SDK connection status
        /// </summary>
        public bool SdkIsConnected => _sdk.IsConnected();

        public IRacingSessionModel? SessionInfo { get; private set; }
        public IRacingDataModel? Telemetry { get; private set; }
        #endregion

        #region Events
        public delegate void TelemetryUpdateEvent(object sender, IRacingDataModel e);

        public delegate void SessionInfoUpdateEvent(object sender, IRacingSessionModel e);

        public event TelemetryUpdateEvent TelemetryUpdated;

        public event SessionInfoUpdateEvent SessionInfoUpdated;

        public event EventHandler Connected;

        public event EventHandler Disconnected;
        #endregion

        #region Contructor
        public SdkWrapper(bool autoStart = false, int updateFrequency = 10)
        {
            _sdk = new IRacingSDK();

            Reset();

            if (autoStart) Start(updateFrequency);
        }
        #endregion

        #region Methods
        public void Start(int updateFrequency = 10)
        {
            if (!IsStarted)
            {
                UpdateFrequency = updateFrequency;
                IsStarted = true;
                Task.Run(() => UpdateLoop());
            }
        }

        public void Stop()
        {
            IsStarted = false;
            Reset();
        }

        private void Reset()
        {
            IsStarted = false;

            SessionInfo = null;
            Telemetry = null;
        }

        private void UpdateLoop()
        {
            int lastSessionUpdate = -1;
            bool lastConnected = false;

            while (IsStarted)
            {
                if (SdkIsConnected)
                {
                    if (!lastConnected) Connected?.Invoke(this, EventArgs.Empty);

                    // Update telemetry
                    IRacingDataModel telemetry = IRacingSDKExtensions.GetSerializedData(_sdk);
                    Telemetry = telemetry;
                    TelemetryUpdated?.Invoke(this, Telemetry);

                    //Telemetry.Data.DisplayUnits

                    // Update session info
                    int newUpdate = _sdk.Header.SessionInfoUpdate;
                    if (newUpdate != lastSessionUpdate)
                    {
                        lastSessionUpdate = newUpdate;
                        IRacingSessionModel session = IRacingSDKExtensions.GetSerializedSessionInfo(_sdk);
                        SessionInfo = session;
                        SessionInfoUpdated?.Invoke(this, SessionInfo);
                    }

                    // Update delay
                    Task.Delay(UpdateDelay);
                }
                else
                {
                    if (lastConnected) Disconnected?.Invoke(this, EventArgs.Empty);
                    Task.Delay(CheckConnectionDelay);
                }
            }
        }
        #endregion
    }
}
