using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkWrapper.Libary.Models.Drivers.Private;
using irsdkSharp.Models;

namespace irsdkWrapper.Libary.Models.Drivers
{
    public class DriverPrivateInfo
    {
        public DriverEngineInfo EngineInfo { get; private set; }
        public DriverForceFeedback ForceFeedback { get; private set; }
        public DriverCarBody CarBody { get; private set; }

        public DriverPrivateInfo(byte[] data, Dictionary<string, VarHeader> headers)
        {
            EngineInfo = new DriverEngineInfo(data, headers);
            ForceFeedback = new DriverForceFeedback(data, headers);
            CarBody = new DriverCarBody(data, headers);
        }
    }
}
