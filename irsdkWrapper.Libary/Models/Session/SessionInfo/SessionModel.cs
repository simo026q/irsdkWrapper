using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irsdkWrapper.Models.Session.SessionInfo
{
    public class SessionModel
    {
        private readonly irsdkSharp.Serialization.Models.Session.SessionInfo.SessionModel _session;

        public SessionModel(irsdkSharp.Serialization.Models.Session.SessionInfo.SessionModel session)
        {
            _session = session;
        }

        public int SessionNum => _session.SessionNum;

        public string SessionLaps => _session.SessionLaps;

        public TimeSpan SessionTime => TimeSpan.FromSeconds(UnitConverter.StringToFloat(_session.SessionTime, " sec"));

        public string SessionName => _session.SessionName;

        public int SessionNumLapsToAvg => _session.SessionNumLapsToAvg;

        public string SessionType => _session.SessionType;

        public string SessionSubType => _session.SessionSubType;

        public string SessionTrackRubberState => _session.SessionTrackRubberState;

        public string SessionSkipped => _session.SessionSkipped;

        public string SessionRunGroupsUsed => _session.SessionRunGroupsUsed;

        /*public List<PositionModel> ResultsPositions
        {
            get;
            set;
        }

        public List<FastestLapModel> ResultsFastestLap
        {
            get;
            set;
        }*/

        public TimeSpan ResultsAverageLapTime => TimeSpan.FromSeconds(_session.ResultsAverageLapTime);

        public int ResultsNumCautionFlags => _session.ResultsNumCautionFlags;

        public int ResultsNumCautionLaps => _session.ResultsNumCautionLaps;

        public int ResultsNumLeadChanges => _session.ResultsNumLeadChanges;

        public int ResultsLapsComplete => _session.ResultsLapsComplete;

        public int ResultsOfficial => _session.ResultsOfficial;
    }
}
