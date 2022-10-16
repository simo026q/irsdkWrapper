using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irsdkWrapper.Models.Session.WeekendInfo
{
    public class WeekendOptionsModel
    {
        private readonly irsdkSharp.Serialization.Models.Session.WeekendInfo.WeekendOptionsModel _weekendOptions;
        
        public WeekendOptionsModel(irsdkSharp.Serialization.Models.Session.WeekendInfo.WeekendOptionsModel weekendOptions)
        {
            _weekendOptions = weekendOptions;
        }

        public int NumStarters => _weekendOptions.NumStarters;

        public string StartingGrid => _weekendOptions.StartingGrid;

        public string QualifyScoring => _weekendOptions.QualifyScoring;

        public string CourseCautions => _weekendOptions.CourseCautions;

        public int StandingStart => _weekendOptions.StandingStart;

        public string Restarts => _weekendOptions.Restarts;

        public string WeatherType => _weekendOptions.WeatherType;

        public string Skies => _weekendOptions.Skies;

        public string WindDirection => _weekendOptions.WindDirection;
        
        public float WindSpeed => UnitConverter.StringToFloat(_weekendOptions.WindSpeed, " km/h");

        public float WeatherTemp => UnitConverter.StringToFloat(_weekendOptions.WeatherTemp, " C");

        public float RelativeHumidity => UnitConverter.StringToFloat(_weekendOptions.RelativeHumidity, " %");

        public float FogLevel => UnitConverter.StringToFloat(_weekendOptions.FogLevel, " %");

        public int Unofficial => _weekendOptions.Unofficial;

        public string CommercialMode => _weekendOptions.CommercialMode;

        public string NightMode => _weekendOptions.NightMode;

        public bool IsFixedSetup => _weekendOptions.IsFixedSetup == 1;

        public string StrictLapsChecking => _weekendOptions.StrictLapsChecking;

        public int HapSOpenRegistration => _weekendOptions.HapSOpenRegistration;

        public int HardcoreLevel => _weekendOptions.HardcoreLevel;

        public string ShortParadeLap => _weekendOptions.ShortParadeLap;

        public string TimeOfDay => _weekendOptions.TimeOfDay;

        public string Date => _weekendOptions.Date;

        public string EarthRotationSpeedupFactor => _weekendOptions.EarthRotationSpeedupFactor;

        public string HasOpenRegistration => _weekendOptions.HasOpenRegistration;

        public int NumJokerLaps => _weekendOptions.NumJokerLaps;

        public string IncidentLimit => _weekendOptions.IncidentLimit;

        public string FastRepairsLimit => _weekendOptions.FastRepairsLimit;

        public int GreenWhiteCheckeredLimit => _weekendOptions.GreenWhiteCheckeredLimit;
    }
}
