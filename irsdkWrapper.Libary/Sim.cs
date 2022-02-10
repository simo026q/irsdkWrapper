using System;
using irsdkSharp;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Models.Data;
using irsdkSharp.Serialization.Models.Session;

namespace irsdkWrapper.Libary
{
    public class Sim
    {
        private IRacingSDK _sdk;
        private IRacingSessionModel _session;

        public int UpdateFrequency { get; set; }

        public Sim(int frequency)
        {
            _sdk = new IRacingSDK();

            UpdateFrequency = frequency;

            IRacingDataModel dataModel = IRacingSDKExtensions.GetSerializedData(_sdk);
            IRacingSessionModel SessionInfo = IRacingSDKExtensions.GetSerializedSessionInfo(_sdk);
        }


    }
}