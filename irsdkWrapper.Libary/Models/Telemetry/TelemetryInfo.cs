using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class TelemetryInfo
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public TelemetryInfo(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        /// <summary>
        /// Density of air at start/finish line
        /// </summary>
        /// <value>kg/m^3</value>
        public float AirDensity => _data.AirDensity;

        /// <summary>
        /// Pressure of air at start/finish line
        /// </summary>
        /// <value>Hg</value>
        public float AirPressure => _data.AirPressure;

        /// <summary>
        /// Temperature of air at start/finish line
        /// </summary>
        /// <value>Celcius</value>
        public float AirTemperature => _data.AirTemp;

        public float Brake => _data.Brake;

        public float BrakeRaw => _data.BrakeRaw;

        public int CamCameraNumber => _data.CamCameraNumber;

        public CameraState CamCameraState => (CameraState)_data.CamCameraState;

        public int CamCarIndex => _data.CamCarIdx;

        public int CamGroupNumber => _data.CamGroupNumber;

        public int CarLeftRight => _data.CarLeftRight;

        public float Clutch => _data.Clutch;

        public float CpuUsageBackground => _data.CpuUsageBG;

        public int DCDriversSoFar => _data.DCDriversSoFar;

        public int DCLapStatus => _data.DCLapStatus;

        public bool dcStarter => _data.dcStarter;

        public DisplayUnit DisplayUnits => (DisplayUnit)_data.DisplayUnits;

        public float dpFastRepair => _data.dpFastRepair;

        public float dpFuelAddKg => _data.dpFuelAddKg;

        public float dpFuelFill => _data.dpFuelFill;

        public float dpLFTireChange => _data.dpLFTireChange;

        public float dpLFTireColdPress => _data.dpLFTireColdPress;

        public float dpLRTireChange => _data.dpLRTireChange;

        public float dpLRTireColdPress => _data.dpLRTireColdPress;

        public float dpRFTireChange => _data.dpRFTireChange;

        public float dpRFTireColdPress => _data.dpRFTireColdPress;

        public float dpRRTireChange => _data.dpRRTireChange;

        public float dpRRTireColdPress => _data.dpRRTireColdPress;

        public float dpWindshieldTearoff => _data.dpWindshieldTearoff;

        public bool DriverMarker => _data.DriverMarker;

        public EngineWarnings EngineWarnings => (EngineWarnings)_data.EngineWarnings;

        public EnterExitReset EnterExitReset => (EnterExitReset)_data.EnterExitReset;

        public int FastRepairAvailable => _data.FastRepairAvailable;

        public int FastRepairUsed => _data.FastRepairUsed;

        public float FogLevel => _data.FogLevel;

        public float FrameRate => _data.FrameRate;

        public float FuelLevel => _data.FuelLevel;

        public float FuelLevelPercentage => _data.FuelLevelPct;

        public float FuelPressure => _data.FuelPress;

        public float FuelUsePerHour => _data.FuelUsePerHour;

        public int Gear => _data.Gear;

        public float HandbrakeRaw => _data.HandbrakeRaw;

        public bool IsDiskLoggingActive => _data.IsDiskLoggingActive;

        public bool IsDiskLoggingEnabled => _data.IsDiskLoggingEnabled;

        public bool IsInGarage => _data.IsInGarage;

        public bool IsOnTrack => _data.IsOnTrack;

        public bool IsOnTrackCar => _data.IsOnTrackCar;

        public bool IsReplayPlaying => _data.IsReplayPlaying;

        public int Lap => _data.Lap;

        public int LapBestLap => _data.LapBestLap;

        public float LapBestLapTime => _data.LapBestLapTime;

        public int LapBestNLapLap => _data.LapBestNLapLap;

        public float LapBestNLapTime => _data.LapBestNLapTime;

        public int LapCompleted => _data.LapCompleted;

        public float LapCurrentLapTime => _data.LapCurrentLapTime;

        public float LapDeltaToBestLap => _data.LapDeltaToBestLap;

        public float LapDeltaToBestLap_DD => _data.LapDeltaToBestLap_DD;

        public bool LapDeltaToBestLap_OK => _data.LapDeltaToBestLap_OK;

        public float LapDeltaToOptimalLap => _data.LapDeltaToOptimalLap;

        public float LapDeltaToOptimalLap_DD => _data.LapDeltaToOptimalLap_DD;

        public bool LapDeltaToOptimalLap_OK => _data.LapDeltaToOptimalLap_OK;

        public float LapDeltaToSessionBestLap => _data.LapDeltaToSessionBestLap;

        public float LapDeltaToSessionBestLap_DD => _data.LapDeltaToSessionBestLap_DD;

        public bool LapDeltaToSessionBestLap_OK => _data.LapDeltaToSessionBestLap_OK;

        public float LapDeltaToSessionLastlLap => _data.LapDeltaToSessionLastlLap;

        public float LapDeltaToSessionLastlLap_DD => _data.LapDeltaToSessionLastlLap_DD;

        public bool LapDeltaToSessionLastlLap_OK => _data.LapDeltaToSessionLastlLap_OK;

        public float LapDeltaToSessionOptimalLap => _data.LapDeltaToSessionOptimalLap;

        public float LapDeltaToSessionOptimalLap_DD => _data.LapDeltaToSessionOptimalLap_DD;

        public bool LapDeltaToSessionOptimalLap_OK => _data.LapDeltaToSessionOptimalLap_OK;

        public float LapDistance => _data.LapDist;

        public float LapDistancePercentage => _data.LapDistPct;

        public int LapLasNLapSeq => _data.LapLasNLapSeq;

        public float LapLastLapTime => _data.LapLastLapTime;

        public float LapLastNLapTime => _data.LapLastNLapTime;

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

        public bool LoadNumTextures => _data.LoadNumTextures;

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

        public float ManifoldPressure => _data.ManifoldPress;

        public bool ManualBoost => _data.ManualBoost;

        public bool ManualNoBoost => _data.ManualNoBoost;

        public float OilLevel => _data.OilLevel;

        public float OilPressure => _data.OilPress;

        public float OilTemperature => _data.OilTemp;

        public bool OkToReloadTextures => _data.OkToReloadTextures;

        public bool IsOnPitRoad => _data.OnPitRoad;

        public float Pitch => _data.Pitch;

        public float PitchRate => _data.PitchRate;

        public float[] PitchRate_ST => _data.PitchRate_ST;

        public float PitOptRepairLeft => _data.PitOptRepairLeft;

        public float PitRepairLeft => _data.PitRepairLeft;

        public bool PitsOpen => _data.PitsOpen;

        public bool PitstopActive => _data.PitstopActive;

        public PitServiceFlags PitServiceFlags => (PitServiceFlags)_data.PitSvFlags;

        public float PitServiceFuel => _data.PitSvFuel;

        public float PitServiceLFP => _data.PitSvLFP;

        public float PitServiceLRP => _data.PitSvLRP;

        public float PitServiceRFP => _data.PitSvRFP;

        public float PitServiceRRP => _data.PitSvRRP;

        public int PlayerCarClassPosition => _data.PlayerCarClassPosition;

        public int PlayerCarDriverIncidentCount => _data.PlayerCarDriverIncidentCount;

        public int PlayerCarIndex => _data.PlayerCarIdx;

        public bool PlayerCarInPitStall => _data.PlayerCarInPitStall;

        public int PlayerCarMyIncidentCount => _data.PlayerCarMyIncidentCount;

        public int PlayerCarPitServiceStatus => _data.PlayerCarPitSvStatus;

        public int PlayerCarPosition => _data.PlayerCarPosition;

        public float PlayerCarPowerAdjust => _data.PlayerCarPowerAdjust;

        public int PlayerCarTeamIncidentCount => _data.PlayerCarTeamIncidentCount;

        public float PlayerCarTowTime => _data.PlayerCarTowTime;

        public float PlayerCarWeightPenalty => _data.PlayerCarWeightPenalty;

        public TrackSurface PlayerTrackSurface => (TrackSurface)_data.PlayerTrackSurface;

        public TrackSurfaceMaterial PlayerTrackSurfaceMaterial => (TrackSurfaceMaterial)_data.PlayerTrackSurfaceMaterial;

        public bool PushToPass => _data.PushToPass;

        public int RaceLaps => _data.RaceLaps;

        public int RadioTransmitCarIndex => _data.RadioTransmitCarIdx;

        public int RadioTransmitFrequencyIndex => _data.RadioTransmitFrequencyIdx;

        public int RadioTransmitRadioIndex => _data.RadioTransmitRadioIdx;

        public float RelativeHumidity => _data.RelativeHumidity;

        public int ReplayFrameNumber => _data.ReplayFrameNum;

        public int ReplayFrameNumberEnd => _data.ReplayFrameNumEnd;

        public bool ReplayPlaySlowMotion => _data.ReplayPlaySlowMotion;

        public int ReplayPlaySpeed => _data.ReplayPlaySpeed;

        public int ReplaySessionNumber => _data.ReplaySessionNum;

        public double ReplaySessionTime => _data.ReplaySessionTime;

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

        public float RPM => _data.RPM;

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

        public SessionFlags SessionFlags => (SessionFlags)_data.SessionFlags;

        public int SessionLapsRemaining => _data.SessionLapsRemain;

        public int SessionLapsRemainingEx => _data.SessionLapsRemainEx;

        public int SessionNumber => _data.SessionNum;

        public SessionState SessionState => (SessionState)_data.SessionState;

        public int SessionTick => _data.SessionTick;

        public double SessionTime => _data.SessionTime;

        public float SessionTimeOfDay => _data.SessionTimeOfDay;

        public double SessionTimeRemaining => _data.SessionTimeRemain;

        public int SessionUniqueID => _data.SessionUniqueID;

        public float ShiftGrindRPM => _data.ShiftGrindRPM;

        public float ShiftIndicatorPct => _data.ShiftIndicatorPct;

        public float ShiftPowerPct => _data.ShiftPowerPct;

        public WeatherForecast Forecast => (WeatherForecast)_data.Skies;

        /// <summary>
        /// GPS vehicle in m/s (Default iRacing output)
        /// </summary>
        /// <value>m/s</value>
        public float Speed => _data.Speed;

        /// <summary>
        /// GPS vehicle speed in km/h
        /// </summary>
        /// <value>km/h</value>
        public float SpeedKph => Speed * 3.6F;

        /// <summary>
        /// GPS vehicle speed in mph
        /// </summary>
        /// <value>mph</value>
        public float SpeedMph => Speed * 2.23694f;

        /// <summary>
        /// GPS vehicle in the unit used by the iRacing UI
        /// </summary>
        /// <value>mph / kph</value>
        public float SpeedLocal
        {
            get
            {
                switch (DisplayUnits)
                {
                    case DisplayUnit.Imperial: return SpeedMph;
                    case DisplayUnit.Metric: return SpeedKph;
                    default: return Speed;
                }
            }
        }

        public float SteeringWheelAngle => _data.SteeringWheelAngle;

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

        public float Throttle => _data.Throttle;

        public float ThrottleRaw => _data.ThrottleRaw;

        public float TireLF_RumblePitch => _data.TireLF_RumblePitch;

        public float TireLR_RumblePitch => _data.TireLR_RumblePitch;

        public float TireRF_RumblePitch => _data.TireRF_RumblePitch;

        public float TireRR_RumblePitch => _data.TireRR_RumblePitch;

        public float TrackTemperature => _data.TrackTemp;

        public float TrackTemperatureCrew => _data.TrackTempCrew;

        public float VelocityX => _data.VelocityX;

        public float[] VelocityX_ST => _data.VelocityX_ST;

        public float VelocityY => _data.VelocityY;

        public float[] VelocityY_ST => _data.VelocityY_ST;

        public float VelocityZ => _data.VelocityZ;

        public float[] VelocityZ_ST => _data.VelocityZ_ST;

        public float VertAccel => _data.VertAccel;

        public float[] VertAccel_ST => _data.VertAccel_ST;

        public float Voltage => _data.Voltage;

        public float WaterLevel => _data.WaterLevel;

        public float WaterTemperature => _data.WaterTemp;

        public WeatherType WeatherType => (WeatherType)_data.WeatherType;

        public float WindDirection => _data.WindDir;

        public float WindVelocity => _data.WindVel;

        public float Yaw => _data.Yaw;

        public float YawNorth => _data.YawNorth;

        public float YawRate => _data.YawRate;

        public float[] YawRate_ST => _data.YawRate_ST;
    }
}
