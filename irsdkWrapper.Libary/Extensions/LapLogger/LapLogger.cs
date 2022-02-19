using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Extensions.LapLogger
{
    interface ILapLogger<T>
    {
        public event EventHandler<LapLoggerEventArgs<T>> LapCompleted;
        public void UpdateTelemetry(IRacingDataModel telemetry);
    }

    public class LapLoggerEventArgs<T> : EventArgs
    {
        public int DriverIdx { get; private set; }

        public T CarInfo { get; private set; }

        public LapLoggerEventArgs(T carInfo, int driverIdx)
        {
            DriverIdx = driverIdx;
            CarInfo = carInfo;
        }
    }
}
