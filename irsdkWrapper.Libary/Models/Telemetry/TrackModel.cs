using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class TrackModel
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public TrackModel(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        /// <summary>
        /// Density of the air at start/finish line
        /// </summary>
        /// <value>kg/m^3</value>
        public float AirDensity => _data.AirDensity;

        /// <summary>
        /// Air pressure at the start/finish line
        /// </summary>
        /// <value>Hg</value>
        public float AirPressure => _data.AirPressure;

        /// <summary>
        /// Air temperature at the start/finish line
        /// </summary>
        /// <value>Celcius</value>
        public float AirTemperatureC => _data.AirTemp;

        /// <summary>
        /// Air temperature at the start/finish line
        /// </summary>
        /// <value>Fahrenheit</value>
        public float AirTemperatureF => UnitConverter.CelsiusToFahrenheit(AirTemperatureC);

        /// <summary>
        /// Fog level
        /// </summary>
        /// <value>Percentage</value>
        public float FogLevel => _data.FogLevel;

        /// <summary>
        /// Relative humidity
        /// </summary>
        /// <value>Percentage</value>
        public float RelativeHumidity => _data.RelativeHumidity;

        /// <summary>
        /// Current forecast (Skies)
        /// </summary>
        public WeatherForecast Forecast => (WeatherForecast)_data.Skies;

        /// <summary>
        /// Track temperature at the start/finish line
        /// </summary>
        /// <value>Celcius</value>
        public float TrackTemperatureC => _data.TrackTemp;

        /// <summary>
        /// Track temperature at the start/finish line
        /// </summary>
        /// <value>Fahrenheit</value>
        public float TrackTemperatureF => UnitConverter.CelsiusToFahrenheit(TrackTemperatureC);

        /// <summary>
        /// Track temperature measured by the crew around the track
        /// </summary>
        /// <value>Celcius</value>
        public float TrackTemperatureCrewC => _data.TrackTempCrew;

        /// <summary>
        /// Track temperature measured by the crew around the track
        /// </summary>
        /// <value>Fahrenheit</value>
        public float TrackTemperatureCrewF => UnitConverter.CelsiusToFahrenheit(TrackTemperatureCrewC);

        /// <summary>
        /// Constant or dynamic weather
        /// </summary>
        public WeatherType WeatherType => (WeatherType)_data.WeatherType;

        /// <summary>
        /// Wind direction at the start/finish line
        /// </summary>
        /// <value>Degrees</value>
        public float WindDirection => UnitConverter.RadiansToDegrees(_data.WindDir);

        /// <summary>
        /// Wind direction in cardinal direction (North, North East, East, South East, etc.) at the start/finish line
        /// </summary>
        /// <value>Cardinal direction</value>
        public CardinalDirection WindDirectionCardinal => UnitConverter.DegreesToCardinalDirection(WindDirection);

        /// <summary>
        /// Wind direction in cardinal direction (N, NE, E, SE, etc.) at the start/finish line
        /// </summary>
        /// <value>Cardinal direction as string</value>
        public string WindDirectionDisplay => UnitConverter.CardinalDirectionShortName(WindDirectionCardinal);

        /// <summary>
        /// Wind speed at the start/finish line
        /// </summary>
        /// <value>m/s</value>
        public float WindSpeed => _data.WindVel;
    }
}
