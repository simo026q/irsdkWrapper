using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Enums.Fastest;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public enum SessionState
    {
        Invalid = 0,
        GetInCar,
        Warmup,
        ParadeLaps,
        Racing,
        Checkered,
        CoolDown
    }
    public class SessionInfo : TelemetryModel
    {
        public SessionInfo(byte[] data, Dictionary<string, VarHeader> headers) : base(data, headers) { }

        public SessionFlags SessionFlags => (SessionFlags)ValueSerializer.GetIntValue(nameof(SessionFlags), _data, _headers);

        public int SessionLapsRemain => ValueSerializer.GetIntValue(nameof(SessionLapsRemain), _data, _headers);

        public int SessionLapsRemainEx => ValueSerializer.GetIntValue(nameof(SessionLapsRemainEx), _data, _headers);

        public int SessionNum => ValueSerializer.GetIntValue(nameof(SessionNum), _data, _headers);

        public SessionState SessionState => (SessionState)ValueSerializer.GetIntValue(nameof(SessionState), _data, _headers);

        public int SessionTick => ValueSerializer.GetIntValue(nameof(SessionTick), _data, _headers);

        public double SessionTime => ValueSerializer.GetFloatValue(nameof(SessionTime), _data, _headers);

        public float SessionTimeOfDay => ValueSerializer.GetFloatValue(nameof(SessionTimeOfDay), _data, _headers);

        public double SessionTimeRemain => ValueSerializer.GetFloatValue(nameof(SessionTimeRemain), _data, _headers);

        public int SessionUniqueID => ValueSerializer.GetIntValue(nameof(SessionUniqueID), _data, _headers);
    }
}
