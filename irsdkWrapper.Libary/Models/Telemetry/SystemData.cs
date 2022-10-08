using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class SystemData
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public SystemData(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public float CpuUsageBackground => _data.CpuUsageBG;

        public DisplayUnit DisplayUnit => (DisplayUnit)_data.DisplayUnits;

        public float FrameRate => _data.FrameRate;

        public bool IsDiskLoggingActive => _data.IsDiskLoggingActive;

        public bool IsDiskLoggingEnabled => _data.IsDiskLoggingEnabled;

        public bool LoadNumTextures => _data.LoadNumTextures;

        public bool OkToReloadTextures => _data.OkToReloadTextures;
    }
}
