using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class InputData
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public InputData(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public float Brake => _data.Brake;

        public float BrakeRaw => _data.BrakeRaw;

        public float Clutch => _data.Clutch;

        /// <summary>
        /// -1=reverse 0=neutral 1=current gear
        /// </summary>
        public int Gear => _data.Gear;

        public GearType GearType
        {
            get
            {
                switch (Gear)
                {
                    case -1:
                        return GearType.Reverse;
                    case 0:
                        return GearType.Neutral;
                    default:
                        return GearType.Forward;
                }
            }
        }

        /// <summary>
        /// Display the gear as R, N or a number for forward gears
        /// </summary>
        public string GearDisplay
        {
            get
            {
                switch (GearType)
                {
                    case GearType.Reverse:
                        return "R";
                    case GearType.Neutral:
                        return "N";
                    default:
                        return Gear.ToString();
                }
            }
        }

        public float HandbrakeRaw => _data.HandbrakeRaw;

        /// <summary>
        /// Steering wheel angle
        /// </summary>
        /// <value>Degrees</value>
        public float SteeringWheelAngle => UnitConverter.RadiansToDegrees(_data.SteeringWheelAngle);

        public float Throttle => _data.Throttle;

        public float ThrottleRaw => _data.ThrottleRaw;
    }
}
