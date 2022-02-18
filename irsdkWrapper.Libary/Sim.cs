using System;
using irsdkSharp;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Models.Data;
using irsdkSharp.Serialization.Models.Session;

namespace irsdkWrapper.Libary
{
    public class Sim
    {
        #region Fields
        private IRacingSDK _sdk;
        #endregion

        #region Properties
        private int UpdateDelay => (int)Math.Round(1000 / (double)UpdateFrequency);

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
                else UpdateFrequency = 1;
            }
        }

        /// <summary>
        /// If the sim has been started
        /// </summary>
        public bool IsStarted { get; private set; } = false;

        /// <summary>
        /// If the Sim is connected and started
        /// </summary>
        public bool IsConnected => SdkIsConnected && IsStarted;

        /// <summary>
        /// SDK connection status
        /// </summary>
        public bool SdkIsConnected => _sdk.IsConnected();

        public bool IsReplay => (IsConnected && Telemetry != null) ? Telemetry.Data.IsReplayPlaying : false;

        public IRacingSessionModel? SessionInfo { get; private set; }
        public IRacingDataModel? Telemetry { get; private set; }
        #endregion

        #region Events
        public delegate void TelemetryUpdateEvent(object sender, IRacingSessionModel e);

        public delegate void SessionInfoUpdateEvent(object sender, IRacingSessionModel e);

        public event TelemetryUpdateEvent TelemetryUpdated;

        public event SessionInfoUpdateEvent SessionInfoUpdated;

        public event EventHandler Connected;

        public event EventHandler Disconnected;
        #endregion

        #region Contructor
        public Sim(bool autoStart = false, int updateFrequency = 10)
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

                    Telemetry.Data.DisplayUnits

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
                    Task.Delay(1000);
                }
            }
        }
        #endregion
    }
}