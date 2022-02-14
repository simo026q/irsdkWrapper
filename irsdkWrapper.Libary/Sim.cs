using System;
using irsdkSharp;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Models.Data;
using irsdkSharp.Serialization.Models.Session;

namespace irsdkWrapper.Libary
{
    public enum SimStatus
    {
        WaitingForSim = 0,
        Connected,
        NotStarted,
        Started
    }
    public class Sim
    {
        #region Fields
        private IRacingSDK _sdk;
        #endregion

        #region Properties
        /// <summary>
        /// Updates per second
        /// </summary>
        public int UpdateFrequency { get; set; }

        /// <summary>
        /// If the sim has been started
        /// </summary>
        public bool IsStarted { get; private set; } = false;

        /// <summary>
        /// SDK connection status
        /// </summary>
        public bool IsConnected => _sdk.IsConnected();
        #endregion

        #region Events
        public delegate void TelemetryUpdateEvent(object sender, DataModel e);

        public delegate void SessionInfoUpdateEvent(object sender, IRacingSessionModel e);

        public event TelemetryUpdateEvent? TelemetryUpdated;

        public event SessionInfoUpdateEvent? SessionInfoUpdated;
        #endregion

        #region Contructor
        public Sim(int updateFrequency = 10, bool autoStart = false)
        {
            UpdateFrequency = updateFrequency;

            _sdk = new IRacingSDK();

            if (autoStart) Start();
        }
        #endregion

        #region Methods
        public void Start()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                Task.Run(() => UpdateLoop());
            }
        }
        public void Stop()
        {
            IsStarted = false;
        }

        private async void UpdateLoop()
        {
            int lastSessionUpdate = -1;

            while (IsStarted)
            {
                if (IsConnected)
                {
                    // Update telemetry
                    IRacingDataModel telemetry = IRacingSDKExtensions.GetSerializedData(_sdk);
                    TelemetryUpdated?.Invoke(this, telemetry.Data);

                    // Update session info
                    int newUpdate = _sdk.Header.SessionInfoUpdate;
                    if (newUpdate != lastSessionUpdate)
                    {
                        lastSessionUpdate = newUpdate;
                        IRacingSessionModel session = IRacingSDKExtensions.GetSerializedSessionInfo(_sdk);
                        SessionInfoUpdated?.Invoke(this, session);
                    }

                    // Update delay
                    int delay = (int)Math.Round(1000 / (double)UpdateFrequency);
                    await Task.Delay(delay);
                }
                else await Task.Delay(1000);
            }
        }
        #endregion
    }
}