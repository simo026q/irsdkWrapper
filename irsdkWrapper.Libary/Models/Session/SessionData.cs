using irsdkWrapper.Enums;
using irsdkWrapper.Models.Session.WeekendInfo;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Session;
using irsdkSharp.Serialization.Models.Session.CameraInfo;

namespace irsdkWrapper.Models.Session
{
    public class SessionData
    {
        private readonly IRacingSessionModel _session;

        public SessionData(IRacingSessionModel session)
        {
            _session = session;
        }

        public CameraInfoModel Camera => _session.CameraInfo;

        private WeekendInfoModel? _weekendInfo;
        public WeekendInfoModel WeekendInfo => _weekendInfo ??= new WeekendInfoModel(_session.WeekendInfo);
    }
}
