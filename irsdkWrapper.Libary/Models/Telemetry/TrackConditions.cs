using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkSharp.Serialization;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public enum WeatherType
    {
        Constant = 0,
        Dynamic
    }
    public enum WeatherForecast
    {
        Clear = 0,
        PartlyCloudy,
        MostlyCloudy,
        Overcast
    }
    public class TrackConditions : TelemetryModel
    {
        public TrackConditions(byte[] data, Dictionary<string, VarHeader> headers) : base(data, headers) { }

        private float? _airDensity;
        public float AirDensity
        {
            get
            {
                if (!_airDensity.HasValue) _airDensity = ValueSerializer.GetFloatValue(nameof(AirDensity), _data, _headers);
                return _airDensity.Value;
            }
        }

        public float AirPressure => ValueSerializer.GetFloatValue(nameof(AirPressure), _data, _headers);

        public float AirTemp => ValueSerializer.GetFloatValue(nameof(AirTemp), _data, _headers);

        public float FogLevel => ValueSerializer.GetFloatValue(nameof(FogLevel), _data, _headers);

        public float RelativeHumidity => ValueSerializer.GetFloatValue(nameof(RelativeHumidity), _data, _headers);

        public WeatherForecast Forecast => (WeatherForecast)ValueSerializer.GetIntValue("Skies", _data, _headers);

        public float TrackTemp => ValueSerializer.GetFloatValue(nameof(TrackTemp), _data, _headers);

        public float TrackTempCrew => ValueSerializer.GetFloatValue(nameof(TrackTempCrew), _data, _headers);

        public WeatherType WeatherType => (WeatherType)ValueSerializer.GetIntValue(nameof(WeatherType), _data, _headers);

        public float WindDir => ValueSerializer.GetFloatValue(nameof(WindDir), _data, _headers);

        public float WindVel => ValueSerializer.GetFloatValue(nameof(WindVel), _data, _headers);
    }
}
