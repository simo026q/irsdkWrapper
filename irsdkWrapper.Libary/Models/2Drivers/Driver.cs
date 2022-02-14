using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkWrapper.Libary.Models.Drivers;
using irsdkSharp.Models;

namespace irsdkWrapper.Libary.Models.Drivers
{
    public class Driver
    {
        public DriverPrivateInfo Private { get; private set; }

        public Driver(byte[] data, Dictionary<string, VarHeader> headers)
        {
            Private = new DriverPrivateInfo(data, headers);
        }
    }
}
