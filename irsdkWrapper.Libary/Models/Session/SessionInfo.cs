using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Session;
using irsdkSharp.Serialization.Models.Session.CameraInfo;

namespace irsdkWrapper.Models.Session
{
    public class SessionInfo
    {
        private readonly IRacingSessionModel _session;

        public SessionInfo(IRacingSessionModel session)
        {
            _session = session;
        }

        public CameraInfoModel Camera => _session.CameraInfo;

        private WeekendInfo? _weekend;
        public WeekendInfo Weekend => _weekend ??= new WeekendInfo(_session.WeekendInfo);
    }
}
