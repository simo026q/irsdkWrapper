using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkWrapper.Extensions.LapLogger;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Extensions.LapLogger.Field
{
    public class FieldLapLogger : ILapLogger<CarModel>
    {
        protected Dictionary<int, CarModel> DriversInfo { get; set; }

        public event EventHandler<LapLoggerEventArgs<CarModel>> LapCompleted;

        public FieldLapLogger()
        {
            DriversInfo = new Dictionary<int, CarModel>();
        }

        public void UpdateTelemetry(IRacingDataModel telemetry)
        {
            foreach (CarModel driver in telemetry.Data.Cars)
            {
                if (DriversInfo.ContainsKey(driver.CarIdx))
                {
                    if (driver.CarIdxLapCompleted > DriversInfo[driver.CarIdx].CarIdxLapCompleted)
                    {
                        LapCompleted?.Invoke(this, new LapLoggerEventArgs<CarModel>(driver, driver.CarIdx));
                    }
                    continue;
                }
                else
                {
                    DriversInfo.Add(driver.CarIdx, driver);
                    LapCompleted?.Invoke(this, new LapLoggerEventArgs<CarModel>(driver, driver.CarIdx));
                }
            }
        }
    }
}
