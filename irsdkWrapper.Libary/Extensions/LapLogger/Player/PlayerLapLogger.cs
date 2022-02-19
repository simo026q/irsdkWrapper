using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkWrapper.Extensions.LapLogger;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Extensions.LapLogger.Player
{
    public class PlayerLapLogger : ILapLogger<PlayerLapInfo>
    {
        public event EventHandler<LapLoggerEventArgs<PlayerLapInfo>> LapCompleted;

        public void UpdateTelemetry(IRacingDataModel telemetry)
        {

        }
    }
}
