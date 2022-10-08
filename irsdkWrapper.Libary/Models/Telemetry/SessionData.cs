using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class SessionData
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public SessionData(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public bool IsInGarage => _data.IsInGarage;

        public bool IsOnTrack => _data.IsOnTrack;

        public bool IsOnTrackCar => _data.IsOnTrackCar;

        public bool IsReplayPlaying => _data.IsReplayPlaying;

        public int Lap => _data.Lap;

        public bool IsOnPitRoad => _data.OnPitRoad;

        public bool PitsOpen => _data.PitsOpen;

        public int RaceLaps => _data.RaceLaps;

        public SessionFlags SessionFlags => (SessionFlags)_data.SessionFlags;

        public int SessionLapsRemaining => _data.SessionLapsRemain;

        public int SessionLapsRemainingEx => _data.SessionLapsRemainEx;

        public int SessionNumber => _data.SessionNum;

        public SessionState SessionState => (SessionState)_data.SessionState;

        public int SessionTick => _data.SessionTick;

        /// <summary>
        /// Time since session start
        /// </summary>
        public TimeSpan SessionTime => TimeSpan.FromSeconds(_data.SessionTime);

        public float SessionTimeOfDay => _data.SessionTimeOfDay;

        /// <summary>
        /// Time left till session ends
        /// </summary>
        public TimeSpan SessionTimeRemaining => TimeSpan.FromSeconds(_data.SessionTimeRemain);

        public int SessionUniqueID => _data.SessionUniqueID;
    }
}
