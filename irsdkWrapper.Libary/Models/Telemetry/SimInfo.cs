using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkSharp.Serialization;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public class SimInfo : TelemetryModel
    {
        public SimInfo(byte[] data, Dictionary<string, VarHeader> headers) : base(data, headers) { }

        public float CpuUsageBG => ValueSerializer.GetFloatValue(nameof(CpuUsageBG), _data, _headers);

        public int DisplayUnits => ValueSerializer.GetIntValue(nameof(DisplayUnits), _data, _headers);

        public float FrameRate => ValueSerializer.GetFloatValue(nameof(FrameRate), _data, _headers);

        public bool IsDiskLoggingActive => ValueSerializer.GetBoolValue(nameof(IsDiskLoggingActive), _data, _headers);

        public bool IsDiskLoggingEnabled => ValueSerializer.GetBoolValue(nameof(IsDiskLoggingEnabled), _data, _headers);
    }
}
