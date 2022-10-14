using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class SimDataModel
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public SimDataModel(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        /// <summary>
        /// Percent of available tim bg thread took with a 1 sec avg
        /// </summary>
        public float CpuUsage => _data.CpuUsageBG;

        /// <summary>
        /// Default units for the user interface
        /// </summary>
        public DisplayUnit DisplayUnit => (DisplayUnit)_data.DisplayUnits;

        /// <summary>
        /// Average frames per second (FPS)
        /// </summary>
        public float FrameRate => _data.FrameRate;

        /// <summary>
        /// Is writting to telemetry file
        /// </summary>
        public bool IsDiskLoggingActive => _data.IsDiskLoggingActive;

        /// <summary>
        /// Is disk based telemetry enabled
        /// </summary>
        public bool IsDiskLoggingEnabled => _data.IsDiskLoggingEnabled;

        /// <summary>
        /// True if the car_num texture will be loaded
        /// </summary>
        public bool WillLoadNumTextures => _data.LoadNumTextures;

        /// <summary>
        /// True if it is ok to reload car textures at this time
        /// </summary>
        public bool CanReloadTextures => _data.OkToReloadTextures;
    }
}
