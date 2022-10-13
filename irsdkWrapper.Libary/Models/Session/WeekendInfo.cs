using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkWrapper.Enums;
using irsdkSharp.Serialization.Models.Session.WeekendInfo;

namespace irsdkWrapper.Models.Session
{
    public class WeekendInfo
    {
        private readonly WeekendInfoModel _weekend;

        public WeekendInfo(WeekendInfoModel weekend)
        {
            _weekend = weekend;
        }

        /// <summary>
        /// Track name (e.g. 'lemans full'
        /// </summary>
        public string TrackName => _weekend.TrackName;

        public int TrackID => _weekend.TrackID;

        /// <summary>
        /// Track length
        /// </summary>
        /// <value>Kilometers</value>
        public float TrackLength => UnitConverter.StringToFloat(_weekend.TrackLength, " km", 0f);

        public string TrackDisplayName => _weekend.TrackDisplayName;

        public string TrackDisplayShortName => _weekend.TrackDisplayShortName;

        public string TrackDirection => _weekend.TrackDirection;

        public string TrackVersion => _weekend.TrackVersion;

        public string TrackConfigName => _weekend.TrackConfigName;

        public string TrackCity => _weekend.TrackCity;

        public string TrackCountry => _weekend.TrackCountry;

        /// <summary>
        /// Track altitude
        /// </summary>
        /// <value>Meters</value>
        public float TrackAltitude => UnitConverter.StringToFloat(_weekend.TrackAltitude, " m");

        /// <summary>
        /// Track latitude
        /// </summary>
        /// <value>Meters</value>
        public float TrackLatitude => UnitConverter.StringToFloat(_weekend.TrackLatitude, " m");

        /// <summary>
        /// Track longitude
        /// </summary>
        /// <value>Meters</value>
        public float TrackLongitude => UnitConverter.StringToFloat(_weekend.TrackLongitude, " m");

        /// <summary>
        /// Track north offset
        /// </summary>
        /// <value>Degrees</value>
        public float TrackNorthOffset => UnitConverter.RadiansToDegrees(
            UnitConverter.StringToFloat(_weekend.TrackNorthOffset, " rad"));

        public int TrackTotalTurns => _weekend.TrackNumTurns;

        /// <summary>
        /// Pitlane speed limit
        /// </summary>
        /// <value>kph</value>
        public float PitlaneSpeedLimitKph => UnitConverter.StringToFloat(_weekend.TrackPitSpeedLimit, " kph");

        /// <summary>
        /// Pitlane speed limit
        /// </summary>
        /// <value>mph</value>
        public float PitlaneSpeedLimitMph => UnitConverter.KphToMph(PitlaneSpeedLimitKph);

        public string TrackType => _weekend.TrackType;

        public string WeatherType => _weekend.TrackWeatherType;

        public WeatherForecast Forecast
        {
            get
            {
                string valueString = _weekend.TrackSkies.Replace(" ", "");

                bool success = Enum.TryParse(valueString, out WeatherForecast forecast);
                if (success) return forecast;

                return 0;
            }
        }

        /// <summary>
        /// Surface temperature of the track
        /// </summary>
        /// <value>Celcius</value>
        public float TrackSurfaceTemperatureC => UnitConverter.StringToFloat(_weekend.TrackSurfaceTemp, " C");

        /// <summary>
        /// Surface temperature of the track
        /// </summary>
        /// <value>Fahrenheit</value>
        public float TrackSurfaceTemperatureF => UnitConverter.CelsiusToFahrenheit(TrackSurfaceTemperatureC);

        /// <summary>
        /// Air temperature of the track
        /// </summary>
        /// <value>Celcius</value>
        public float AirTemperatureC => UnitConverter.StringToFloat(_weekend.TrackAirTemp, " C");

        /// <summary>
        /// Air temperature of the track
        /// </summary>
        /// <value>Fahrenheit</value>
        public float AirTemperatureF => UnitConverter.CelsiusToFahrenheit(AirTemperatureC);

        /// <summary>
        /// Air pressure of the track
        /// </summary>
        /// <value>Hg</value>
        public float AirPressure => UnitConverter.StringToFloat(_weekend.TrackAirPressure, " Hg");

        /// <summary>
        /// Track wind speed
        /// </summary>
        /// <value>m/s</value>
        public float WindSpeed => UnitConverter.StringToFloat(_weekend.TrackWindVel, " m/s");

        /// <summary>
        /// Wind direction at the start/finish line
        /// </summary>
        /// <value>Degrees</value>
        public float WindDirection => UnitConverter.RadiansToDegrees(
            UnitConverter.StringToFloat(_weekend.TrackWindDir, " rad"));

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
        /// Relative humidity
        /// </summary>
        /// <value>Percentage</value>
        public float RelativeHumidity => UnitConverter.StringToFloat(_weekend.TrackRelativeHumidity, " %");

        /// <summary>
        /// Fog level
        /// </summary>
        /// <value>Percentage</value>
        public float FogLevel => UnitConverter.StringToFloat(_weekend.TrackFogLevel, " %");

        public int TrackCleanup => _weekend.TrackCleanup;

        public bool IsDynamicTrack => _weekend.TrackDynamicTrack == 1;

        public int SeriesID => _weekend.SeriesID;

        public int SeasonID => _weekend.SeasonID;

        public int SessionID => _weekend.SessionID;

        public int SubSessionID => _weekend.SubSessionID;

        public int LeagueID => _weekend.LeagueID;

        public bool IsOfficial => _weekend.Official == 1;

        public int RaceWeek => _weekend.RaceWeek;

        public string EventType => _weekend.EventType;

        public string Category => _weekend.Category;

        public string SimMode => _weekend.SimMode;

        public bool IsTeamRacing => _weekend.TeamRacing == 1;

        public int MinimumDrivers => _weekend.MinDrivers;

        public int MaximumDrivers => _weekend.MaxDrivers;

        public string DCRuleSet => _weekend.DCRuleSet;

        public int QualifierMustStartRace => _weekend.QualifierMustStartRace;

        public int NumCarClasses => _weekend.NumCarClasses;

        public int NumCarTypes => _weekend.NumCarTypes;

        public string HeatRacing => _weekend.HeatRacing;

        public string BuildType => _weekend.BuildType;

        public string BuildTarget => _weekend.BuildTarget;

        public string BuildVersion => _weekend.BuildVersion;

        public WeekendOptionsModel WeekendOptions => _weekend.WeekendOptions;

        public TelemetryOptionsModel TelemetryOptions => _weekend.TelemetryOptions;
    }
}
