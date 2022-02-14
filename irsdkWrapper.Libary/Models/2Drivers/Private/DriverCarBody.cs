using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Serialization;
using irsdkSharp.Models;

namespace irsdkWrapper.Libary.Models.Drivers.Private
{
    public class DriverCarBody
    {
        #region Fields
        private readonly byte[] _data;
        private readonly Dictionary<string, VarHeader> _headers;
        #endregion

        #region Contructor
        public DriverCarBody(byte[] data, Dictionary<string, VarHeader> headers)
        {
            _data = data;
            _headers = headers;
        }
        #endregion

        #region Properties
        public float LatAccel => ValueSerializer.GetFloatValue(nameof(LatAccel), _data, _headers);

        public float[] LatAccel_ST => ValueSerializer.GetFloatArrayValue(nameof(LatAccel_ST), _data, _headers);

        public float LongAccel => ValueSerializer.GetFloatValue(nameof(LongAccel), _data, _headers);

        public float[] LongAccel_ST => ValueSerializer.GetFloatArrayValue(nameof(LongAccel_ST), _data, _headers);

        public float Pitch => ValueSerializer.GetFloatValue(nameof(Pitch), _data, _headers);

        public float PitchRate => ValueSerializer.GetFloatValue(nameof(PitchRate), _data, _headers);

        public float[] PitchRate_ST => ValueSerializer.GetFloatArrayValue(nameof(PitchRate_ST), _data, _headers);

        public float Roll => ValueSerializer.GetFloatValue(nameof(Roll), _data, _headers);

        public float RollRate => ValueSerializer.GetFloatValue(nameof(RollRate), _data, _headers);

        public float[] RollRate_ST => ValueSerializer.GetFloatArrayValue(nameof(RollRate_ST), _data, _headers);

        public float VelocityX => ValueSerializer.GetFloatValue(nameof(VelocityX), _data, _headers);

        public float[] VelocityX_ST => ValueSerializer.GetFloatArrayValue(nameof(VelocityX_ST), _data, _headers);

        public float VelocityY => ValueSerializer.GetFloatValue(nameof(VelocityY), _data, _headers);

        public float[] VelocityY_ST => ValueSerializer.GetFloatArrayValue(nameof(VelocityY_ST), _data, _headers);

        public float VelocityZ => ValueSerializer.GetFloatValue(nameof(VelocityZ), _data, _headers);

        public float[] VelocityZ_ST => ValueSerializer.GetFloatArrayValue(nameof(VelocityZ_ST), _data, _headers);

        public float VertAccel => ValueSerializer.GetFloatValue(nameof(VertAccel), _data, _headers);

        public float[] VertAccel_ST => ValueSerializer.GetFloatArrayValue(nameof(VertAccel_ST), _data, _headers);

        public float Yaw => ValueSerializer.GetFloatValue(nameof(Yaw), _data, _headers);

        public float YawNorth => ValueSerializer.GetFloatValue(nameof(YawNorth), _data, _headers);

        public float YawRate => ValueSerializer.GetFloatValue(nameof(YawRate), _data, _headers);

        public float[] YawRate_ST => ValueSerializer.GetFloatArrayValue(nameof(YawRate_ST), _data, _headers);
        #endregion
    }
}
