using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public abstract class TelemetryModel
    {
        protected readonly byte[] _data;
        protected readonly Dictionary<string, VarHeader> _headers;

        public TelemetryModel(byte[] data, Dictionary<string, VarHeader> headers)
        {
            _data = data;
            _headers = headers;
        }
    }
}
