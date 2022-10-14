using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry.Driver
{
    public class VehicleModel
    {
        private readonly DataModel _data;

        public VehicleModel(DataModel telemetry)
        {
            _data = telemetry;
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

        /// <summary>
        /// In car trigger car starter
        /// </summary>
        public bool IsStarting => _data.dcStarter;

        public float LatAccel => _data.LatAccel;

        public float[] LatAccel_ST => _data.LatAccel_ST;

        public float LFbrakeLinePressure => _data.LFbrakeLinePress;

        public float LFcoldPressure => _data.LFcoldPressure;

        public float LFshockDefl => _data.LFshockDefl;

        public float[] LFshockDefl_ST => _data.LFshockDefl_ST;

        public float LFshockVel => _data.LFshockVel;

        public float[] LFshockVel_ST => _data.LFshockVel_ST;

        public float LFtempCL => _data.LFtempCL;

        public float LFtempCM => _data.LFtempCM;

        public float LFtempCR => _data.LFtempCR;

        public float LFwearL => _data.LFwearL;

        public float LFwearM => _data.LFwearM;

        public float LFwearR => _data.LFwearR;

        public float LongAccel => _data.LongAccel;

        public float[] LongAccel_ST => _data.LongAccel_ST;

        public float LRbrakeLinePressure => _data.LRbrakeLinePress;

        public float LRcoldPressure => _data.LRcoldPressure;

        public float LRshockDefl => _data.LRshockDefl;

        public float[] LRshockDefl_ST => _data.LRshockDefl_ST;

        public float LRshockVel => _data.LRshockVel;

        public float[] LRshockVel_ST => _data.LRshockVel_ST;

        public float LRtempCL => _data.LRtempCL;

        public float LRtempCM => _data.LRtempCM;

        public float LRtempCR => _data.LRtempCR;

        public float LRwearL => _data.LRwearL;

        public float LRwearM => _data.LRwearM;

        public float LRwearR => _data.LRwearR;

        public float Pitch => _data.Pitch;

        public float PitchRate => _data.PitchRate;

        public float[] PitchRate_ST => _data.PitchRate_ST;

        public float RFbrakeLinePressure => _data.RFbrakeLinePress;

        public float RFcoldPressure => _data.RFcoldPressure;

        public float RFshockDefl => _data.RFshockDefl;

        public float[] RFshockDefl_ST => _data.RFshockDefl_ST;

        public float RFshockVel => _data.RFshockVel;

        public float[] RFshockVel_ST => _data.RFshockVel_ST;

        public float RFtempCL => _data.RFtempCL;

        public float RFtempCM => _data.RFtempCM;

        public float RFtempCR => _data.RFtempCR;

        public float RFwearL => _data.RFwearL;

        public float RFwearM => _data.RFwearM;

        public float RFwearR => _data.RFwearR;

        public float Roll => _data.Roll;

        public float RollRate => _data.RollRate;

        public float[] RollRate_ST => _data.RollRate_ST;

        public float RRbrakeLinePressure => _data.RRbrakeLinePress;

        public float RRcoldPressure => _data.RRcoldPressure;

        public float RRshockDefl => _data.RRshockDefl;

        public float[] RRshockDefl_ST => _data.RRshockDefl_ST;

        public float RRshockVel => _data.RRshockVel;

        public float[] RRshockVel_ST => _data.RRshockVel_ST;

        public float RRtempCL => _data.RRtempCL;

        public float RRtempCM => _data.RRtempCM;

        public float RRtempCR => _data.RRtempCR;

        public float RRwearL => _data.RRwearL;

        public float RRwearM => _data.RRwearM;

        public float RRwearR => _data.RRwearR;

        public float TireLF_RumblePitch => _data.TireLF_RumblePitch;

        public float TireLR_RumblePitch => _data.TireLR_RumblePitch;

        public float TireRF_RumblePitch => _data.TireRF_RumblePitch;

        public float TireRR_RumblePitch => _data.TireRR_RumblePitch;

        public float VelocityX => _data.VelocityX;

        public float[] VelocityX_ST => _data.VelocityX_ST;

        public float VelocityY => _data.VelocityY;

        public float[] VelocityY_ST => _data.VelocityY_ST;

        public float VelocityZ => _data.VelocityZ;

        public float[] VelocityZ_ST => _data.VelocityZ_ST;

        public float VertAccel => _data.VertAccel;

        public float[] VertAccel_ST => _data.VertAccel_ST;

        public float Yaw => _data.Yaw;

        public float YawNorth => _data.YawNorth;

        public float YawRate => _data.YawRate;

        public float[] YawRate_ST => _data.YawRate_ST;
    }
}
