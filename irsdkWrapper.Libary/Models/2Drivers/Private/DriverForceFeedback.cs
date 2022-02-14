using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Serialization;
using irsdkSharp.Models;

namespace irsdkWrapper.Libary.Models.Drivers.Private
{
    public class DriverForceFeedback
    {
        #region Fields
        private readonly byte[] _data;
        private readonly Dictionary<string, VarHeader> _headers;
        #endregion

        #region Contructor
        public DriverForceFeedback(byte[] data, Dictionary<string, VarHeader> headers)
        {
            _data = data;
            _headers = headers;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Steering wheel max angle
        /// </summary>
        /// <value>Radians</value>
        public float SteeringWheelAngleMax => ValueSerializer.GetFloatValue(nameof(SteeringWheelAngleMax), _data, _headers);

        /// <summary>
        /// ????
        /// </summary>
        public float SteeringWheelMaxForceNm => ValueSerializer.GetFloatValue(nameof(SteeringWheelMaxForceNm), _data, _headers);

        /// <summary>
        /// Force feedback % max damping
        /// </summary>
        /// <value>Percentage</value>
        public float SteeringWheelPctDamper => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctDamper), _data, _headers);

        /// <summary>
        /// Force feedback % max torque on steering shaft unsigned
        /// </summary>
        /// <value>Percentage</value>
        public float SteeringWheelPctTorque => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctTorque), _data, _headers);

        /// <summary>
        /// Force feedback % max torque on steering shaft signed
        /// </summary>
        /// <value>Percentage</value>
        public float SteeringWheelPctTorqueSign => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctTorqueSign), _data, _headers);

        /// <summary>
        /// Force feedback % max torque on steering shaft signed stops
        /// </summary>
        /// <value>Percentage</value>
        public float SteeringWheelPctTorqueSignStops => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctTorqueSignStops), _data, _headers);

        /// <summary>
        /// Peak torque mapping to direct input units for FFB
        /// </summary>
        /// <value>Newton-meter</value>
        public float SteeringWheelPeakForceNm => ValueSerializer.GetFloatValue(nameof(SteeringWheelPeakForceNm), _data, _headers);

        /// <summary>
        /// Output torque on steering shaf
        /// </summary>
        /// <value>Newton-meter</value>
        public float SteeringWheelTorque => ValueSerializer.GetFloatValue(nameof(SteeringWheelTorque), _data, _headers);

        /// <summary>
        /// ????
        /// </summary>
        public float[] SteeringWheelTorque_ST => ValueSerializer.GetFloatArrayValue(nameof(SteeringWheelTorque_ST), _data, _headers);

        /// <summary>
        /// ????
        /// </summary>
        public bool SteeringWheelUseLinear => ValueSerializer.GetBoolValue(nameof(SteeringWheelUseLinear), _data, _headers);
        #endregion
    }
}
