using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry.Driver
{
    public class DriverModel
    {
        private readonly DataModel _data;

        public DriverModel(DataModel telemetry)
        {
            _data = telemetry;
        }

        private PitStopModel? _pitStop;
        public PitStopModel PitStop => _pitStop ??= new PitStopModel(_data);

        public InputModel? _input;
        public InputModel? Input => _input ??= new InputModel(_data);

        public ForceFeedbackModel? _forceFeedback;
        public ForceFeedbackModel? ForceFeedback => _forceFeedback ??= new ForceFeedbackModel(_data);

        public VehicleModel? _vehicle;
        public VehicleModel? Vehicle => _vehicle ??= new VehicleModel(_data);

        public EnterExitReset EnterExitReset => (EnterExitReset)_data.EnterExitReset;

        public CarLeftRight CarLeftRight => (CarLeftRight)_data.CarLeftRight;

        /// <summary>
        /// Number of team drivers who have run a stpublic int
        /// </summary>
        public int DCDriversSoFar => _data.DCDriversSoFar;

        /// <summary>
        /// Status of driver change lap requirements
        /// </summary>
        public int DCLapStatus => _data.DCLapStatus;

        public int RadioTransmitCarIndex => _data.RadioTransmitCarIdx;

        public int RadioTransmitFrequencyIndex => _data.RadioTransmitFrequencyIdx;

        public int RadioTransmitRadioIndex => _data.RadioTransmitRadioIdx;

        /// <summary>
        /// Car in garage physics running
        /// </summary>
        public bool IsInGarage => _data.IsInGarage;

        /// <summary>
        /// Car on track physics running with player in car
        /// </summary>
        public bool IsOnTrack => _data.IsOnTrack;

        /// <summary>
        /// Car on track physics running
        /// </summary>
        public bool IsOnTrackCar => _data.IsOnTrackCar;

        /// <summary>
        /// Is the player car on pit road between the cones
        /// </summary>
        public bool IsOnPitRoad => _data.OnPitRoad;

        /// <summary>
        /// Players best lap number
        /// </summary>
        public int BestLapNumber => _data.LapBestLap;

        /// <summary>
        /// Players best lap time
        /// </summary>
        public TimeSpan BestLapTime => TimeSpan.FromSeconds(_data.LapBestLapTime);

        /// <summary>
        /// Player last lap in best N average lap time
        /// </summary>
        public int BestNLapNumber => _data.LapBestNLapLap;

        /// <summary>
        /// Player best N average lap time
        /// </summary>
        public TimeSpan BestNLapTime => TimeSpan.FromSeconds(_data.LapBestNLapTime);

        /// <summary>
        /// Laps completed count
        /// </summary>
        public int LapCompleted => _data.LapCompleted;

        /// <summary>
        /// Estimate of players current lap time as shown in F3 box
        /// </summary>
        public TimeSpan CurrentLapTime => TimeSpan.FromSeconds(_data.LapCurrentLapTime);

        /// <summary>
        /// Delta time for best lap
        /// </summary>
        public TimeSpan BestLapTimeDelta => TimeSpan.FromSeconds(_data.LapDeltaToBestLap);

        /// <summary>
        /// Rate of change of delta time for best lap
        /// </summary>
        public float BestLapTimeDeltaChange => _data.LapDeltaToBestLap_DD;

        /// <summary>
        /// Delta time for best lap is valid
        /// </summary>
        public bool BestLapTimeDeltaIsValid => _data.LapDeltaToBestLap_OK;

        /// <summary>
        /// Delta time for optimal lap
        /// </summary>
        public TimeSpan OptimalLapTimeDelta => TimeSpan.FromSeconds(_data.LapDeltaToOptimalLap);

        /// <summary>
        /// Rate of change of delta time for optimal lap
        /// </summary>
        public float OptimalLapTimeDeltaChange => _data.LapDeltaToOptimalLap_DD;

        /// <summary>
        /// Delta time for optimal lap is valid
        /// </summary>
        public bool OptimalLapTimeDeltaIsValid => _data.LapDeltaToOptimalLap_OK;

        /// <summary>
        /// Delta time for session best lap
        /// </summary>
        public TimeSpan SessionBestLapTimeDelta => TimeSpan.FromSeconds(_data.LapDeltaToSessionBestLap);

        /// <summary>
        /// Rate of change of delta time for session best lap
        /// </summary>
        public float SessionBestLapTimeDeltaChange => _data.LapDeltaToSessionBestLap_DD;

        /// <summary>
        /// Delta time for session best lap is valid
        /// </summary>
        public bool SessionBestLapTimeDeltaIsValid => _data.LapDeltaToSessionBestLap_OK;

        /// <summary>
        /// Delta time for session last lap
        /// </summary>
        public TimeSpan SessionLastLapTimeDelta => TimeSpan.FromSeconds(_data.LapDeltaToSessionLastLap);

        /// <summary>
        /// Rate of change of delta time for session last lap
        /// </summary>
        public float SessionLastLapTimeDeltaChange => _data.LapDeltaToSessionLastLap_DD;

        /// <summary>
        /// Delta time for session last lap is valid
        /// </summary>
        public bool SessionLastLapTimeDeltaIsValid => _data.LapDeltaToSessionLastLap_OK;

        /// <summary>
        /// Delta time for session optimal lap
        /// </summary>
        public TimeSpan SessionOptimalLapTimeDelta => TimeSpan.FromSeconds(_data.LapDeltaToSessionOptimalLap);

        /// <summary>
        /// Rate of change of delta time for session optimal lap
        /// </summary>
        public float SessionOptimalLapTimeDeltaChange => _data.LapDeltaToSessionOptimalLap_DD;

        /// <summary>
        /// Delta time for session optimal lap is valid
        /// </summary>
        public bool SessionOptimalLapTimeDeltaIsValid => _data.LapDeltaToSessionOptimalLap_OK;

        /// <summary>
        /// Meters traveled from the start/finish line this lap
        /// </summary>
        public float LapDistance => _data.LapDist;

        /// <summary>
        /// Percentage distance around lap
        /// </summary>
        public float LapDistancePercentage => _data.LapDistPct;

        /// <summary>
        /// Player num consecutive clean laps completed for N average
        /// </summary>
        public int LapLasNLapSeq => _data.LapLasNLapSeq;

        /// <summary>
        /// Players last lap time
        /// </summary>
        public TimeSpan LastLapTime => TimeSpan.FromSeconds(_data.LapLastLapTime);

        /// <summary>
        /// Player last N average lap time
        /// </summary>
        public TimeSpan LapLastNLapTime => TimeSpan.FromSeconds(_data.LapLastNLapTime);

        /// <summary>
        /// Players class position in race
        /// </summary>
        public int ClassPosition => _data.PlayerCarClassPosition;

        /// <summary>
        /// Teams current drivers incident count for this session
        /// </summary>
        public int DriverIncidentCount => _data.PlayerCarDriverIncidentCount;

        /// <summary>
        /// Players dry tire set limit
        /// </summary>
        public int DryTireLimit => _data.PlayerCarDryTireSetLimit;

        /// <summary>
        /// Players carIdx
        /// </summary>
        public int CarIndex => _data.PlayerCarIdx;

        /// <summary>
        /// Players car is properly in the pitstall
        /// </summary>
        public bool IsInPitStall => _data.PlayerCarInPitStall;

        /// <summary>
        /// Players own incident count for this session
        /// </summary>
        public int IncidentCount => _data.PlayerCarMyIncidentCount;

        /// <summary>
        /// Players position in race
        /// </summary>
        public int Position => _data.PlayerCarPosition;

        /// <summary>
        /// Players power adjust
        /// </summary>
        public float PowerAdjustment => _data.PlayerCarPowerAdjust;

        /// <summary>
        /// Players team incident count for this session
        /// </summary>
        public int TeamIncidentCount => _data.PlayerCarTeamIncidentCount;

        /// <summary>
        /// Players car is being towed if time is greater than zero
        /// </summary>
        public float TowTime => _data.PlayerCarTowTime;

        /// <summary>
        /// Players car is being towed
        /// </summary>
        public bool IsTowing => TowTime > 0;

        /// <summary>
        /// Players weight penalty
        /// </summary>
        public float WeightPenalty => _data.PlayerCarWeightPenalty;

        public TrackSurface PlayerTrackSurface => (TrackSurface)_data.PlayerTrackSurface;

        public TrackSurfaceMaterial PlayerTrackSurfaceMaterial => (TrackSurfaceMaterial)_data.PlayerTrackSurfaceMaterial;

        /// <summary>
        /// Driver activated flag
        /// </summary>
        public bool DriverMarker => _data.DriverMarker;

        /// <summary>
        /// How many fast repairs left - 255 is unlimited
        /// </summary>
        public int FastRepairsAvailable => _data.FastRepairAvailable;

        /// <summary>
        /// If there is unlimited fast repairs
        /// </summary>
        public bool FastRepairsIsUnlimited => FastRepairsAvailable == 255;

        /// <summary>
        /// How many fast repairs used so far
        /// </summary>
        public int FastRepairsUsed => _data.FastRepairUsed;
    }
}
