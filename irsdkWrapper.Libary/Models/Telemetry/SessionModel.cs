using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class SessionModel
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public SessionModel(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public int Lap => _data.Lap;

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
