using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkSharp.Serialization;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public class ReplayInfo : TelemetryModel
    {
        public ReplayInfo(byte[] data, Dictionary<string, VarHeader> headers) : base(data, headers) { }

        public int ReplayFrameNum => ValueSerializer.GetIntValue(nameof(ReplayFrameNum), _data, _headers);

        public int ReplayFrameNumEnd => ValueSerializer.GetIntValue(nameof(ReplayFrameNumEnd), _data, _headers);

        public bool ReplayPlaySlowMotion => ValueSerializer.GetBoolValue(nameof(ReplayPlaySlowMotion), _data, _headers);

        public int ReplayPlaySpeed => ValueSerializer.GetIntValue(nameof(ReplayPlaySpeed), _data, _headers);

        public int ReplaySessionNum => ValueSerializer.GetIntValue(nameof(ReplaySessionNum), _data, _headers);

        public double ReplaySessionTime => ValueSerializer.GetFloatValue(nameof(ReplaySessionTime), _data, _headers);
    }
}
