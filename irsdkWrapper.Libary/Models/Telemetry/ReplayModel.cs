using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class ReplayModel
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public ReplayModel(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public bool IsReplay => _data.IsReplayPlaying;

        public int CamCameraNumber => _data.CamCameraNumber;

        public CameraState CamCameraState => (CameraState)_data.CamCameraState;

        public int CamCarIndex => _data.CamCarIdx;

        public int CamGroupNumber => _data.CamGroupNumber;

        public int ReplayFrameNumber => _data.ReplayFrameNum;

        public int ReplayFrameNumberEnd => _data.ReplayFrameNumEnd;

        public bool ReplayPlaySlowMotion => _data.ReplayPlaySlowMotion;

        public int ReplayPlaySpeed => _data.ReplayPlaySpeed;

        public int ReplaySessionNumber => _data.ReplaySessionNum;

        public double ReplaySessionTime => _data.ReplaySessionTime;
    }
}
