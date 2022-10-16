using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irsdkWrapper.Models.Session.SessionInfo
{
    public class SessionInfoModel
    {
        private readonly irsdkSharp.Serialization.Models.Session.SessionInfo.SessionInfoModel _sessionInfo;

        public SessionInfoModel(irsdkSharp.Serialization.Models.Session.SessionInfo.SessionInfoModel sessionInfo)
        {
            _sessionInfo = sessionInfo;
        }

        public int NumSessions => _sessionInfo.NumSessions;

        public IEnumerable<SessionModel> Sessions => _sessionInfo.Sessions.Select(s => new SessionModel(s));
    }
}
