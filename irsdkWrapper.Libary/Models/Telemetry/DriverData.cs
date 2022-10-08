using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class DriverData
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public DriverData(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public int LapBestLap => _data.LapBestLap;

        public float LapBestLapTime => _data.LapBestLapTime;

        public int LapBestNLapLap => _data.LapBestNLapLap;

        public float LapBestNLapTime => _data.LapBestNLapTime;

        public int LapCompleted => _data.LapCompleted;

        public float LapCurrentLapTime => _data.LapCurrentLapTime;

        public float LapDeltaToBestLap => _data.LapDeltaToBestLap;

        public float LapDeltaToBestLap_DD => _data.LapDeltaToBestLap_DD;

        public bool LapDeltaToBestLap_OK => _data.LapDeltaToBestLap_OK;

        public float LapDeltaToOptimalLap => _data.LapDeltaToOptimalLap;

        public float LapDeltaToOptimalLap_DD => _data.LapDeltaToOptimalLap_DD;

        public bool LapDeltaToOptimalLap_OK => _data.LapDeltaToOptimalLap_OK;

        public float LapDeltaToSessionBestLap => _data.LapDeltaToSessionBestLap;

        public float LapDeltaToSessionBestLap_DD => _data.LapDeltaToSessionBestLap_DD;

        public bool LapDeltaToSessionBestLap_OK => _data.LapDeltaToSessionBestLap_OK;

        public float LapDeltaToSessionLastlLap => _data.LapDeltaToSessionLastlLap;

        public float LapDeltaToSessionLastlLap_DD => _data.LapDeltaToSessionLastlLap_DD;

        public bool LapDeltaToSessionLastlLap_OK => _data.LapDeltaToSessionLastlLap_OK;

        public float LapDeltaToSessionOptimalLap => _data.LapDeltaToSessionOptimalLap;

        public float LapDeltaToSessionOptimalLap_DD => _data.LapDeltaToSessionOptimalLap_DD;

        public bool LapDeltaToSessionOptimalLap_OK => _data.LapDeltaToSessionOptimalLap_OK;

        public float LapDistance => _data.LapDist;

        public float LapDistancePercentage => _data.LapDistPct;

        public int LapLasNLapSeq => _data.LapLasNLapSeq;

        public float LapLastLapTime => _data.LapLastLapTime;

        public float LapLastNLapTime => _data.LapLastNLapTime;

        public int PlayerCarClassPosition => _data.PlayerCarClassPosition;

        public int PlayerCarDriverIncidentCount => _data.PlayerCarDriverIncidentCount;

        public int PlayerCarIndex => _data.PlayerCarIdx;

        public bool PlayerCarInPitStall => _data.PlayerCarInPitStall;

        public int PlayerCarMyIncidentCount => _data.PlayerCarMyIncidentCount;

        public int PlayerCarPitServiceStatus => _data.PlayerCarPitSvStatus;

        public int PlayerCarPosition => _data.PlayerCarPosition;

        public float PlayerCarPowerAdjust => _data.PlayerCarPowerAdjust;

        public int PlayerCarTeamIncidentCount => _data.PlayerCarTeamIncidentCount;

        public float PlayerCarTowTime => _data.PlayerCarTowTime;

        public float PlayerCarWeightPenalty => _data.PlayerCarWeightPenalty;

        public TrackSurface PlayerTrackSurface => (TrackSurface)_data.PlayerTrackSurface;

        public TrackSurfaceMaterial PlayerTrackSurfaceMaterial => (TrackSurfaceMaterial)_data.PlayerTrackSurfaceMaterial;
    }
}
