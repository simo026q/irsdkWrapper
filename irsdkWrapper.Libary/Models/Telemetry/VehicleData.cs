using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class VehicleData
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public VehicleData(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public EngineWarnings EngineWarnings => (EngineWarnings)_data.EngineWarnings;

        /// <summary>
        /// Liters of fuel remaining in the tank
        /// </summary>
        /// <value>Liters</value>
        public float FuelLevel => _data.FuelLevel;

        /// <summary>
        /// Percent fuel remaining in the tank
        /// </summary>
        /// <value>Percentage</value>
        public float FuelLevelPercentage => _data.FuelLevelPct;

        public float FuelPressure => _data.FuelPress;

        public float FuelUsePerHour => _data.FuelUsePerHour;

        public float ManifoldPressure => _data.ManifoldPress;

        public bool ManualBoost => _data.ManualBoost;

        public bool ManualNoBoost => _data.ManualNoBoost;

        public float OilLevel => _data.OilLevel;

        public float OilPressure => _data.OilPress;

        public float OilTemperature => _data.OilTemp;

        public bool PushToPass => _data.PushToPass;

        public float RPM => _data.RPM;

        public float ShiftGrindRPM => _data.ShiftGrindRPM;

        public float ShiftIndicatorPercentage => _data.ShiftIndicatorPct;

        public float ShiftPowerPercentage => _data.ShiftPowerPct;

        /// <summary>
        /// Vehicle GPS speed in m/s (Default iRacing output)
        /// </summary>
        /// <value>m/s</value>
        public float Speed => _data.Speed;

        /// <summary>
        /// Vehicle GPS speed in km/h
        /// </summary>
        /// <value>km/h</value>
        public float SpeedKph => UnitConverter.MsToKph(Speed);

        /// <summary>
        /// Vehicle GPS speed in mph
        /// </summary>
        /// <value>mph</value>
        public float SpeedMph => UnitConverter.MsToMph(Speed);

        /// <summary>
        /// Vehicle GPS in the <see cref="DisplayUnit"/>
        /// </summary>
        /// <value>mph / kph</value>
        public float SpeedLocal
        {
            get
            {
                switch ((DisplayUnit)_data.DisplayUnits)
                {
                    case DisplayUnit.Imperial: return SpeedMph;
                    case DisplayUnit.Metric: return SpeedKph;
                    default: return Speed;
                }
            }
        }

        public float Voltage => _data.Voltage;

        public float WaterLevel => _data.WaterLevel;

        public float WaterTemperature => _data.WaterTemp;
    }
}
