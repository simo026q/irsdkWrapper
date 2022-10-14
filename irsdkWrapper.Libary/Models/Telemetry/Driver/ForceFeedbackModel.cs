using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry.Driver
{
    public class ForceFeedbackModel
    {
        private readonly DataModel _data;

        public ForceFeedbackModel(DataModel telemetry)
        {
            _data = telemetry;
        }

        public float SteeringWheelAngleMax => _data.SteeringWheelAngleMax;

        public float SteeringWheelMaxForceNm => _data.SteeringWheelMaxForceNm;

        public float SteeringWheelPctDamper => _data.SteeringWheelPctDamper;

        public float SteeringWheelPctTorque => _data.SteeringWheelPctTorque;

        public float SteeringWheelPctTorqueSign => _data.SteeringWheelPctTorqueSign;

        public float SteeringWheelPctTorqueSignStops => _data.SteeringWheelPctTorqueSignStops;

        public float SteeringWheelPeakForceNm => _data.SteeringWheelPeakForceNm;

        public float SteeringWheelTorque => _data.SteeringWheelTorque;

        public float[] SteeringWheelTorque_ST => _data.SteeringWheelTorque_ST;

        public bool SteeringWheelUseLinear => _data.SteeringWheelUseLinear;
    }
}
