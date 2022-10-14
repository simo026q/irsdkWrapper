using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry.Driver
{
    public class PitStopModel
    {
        private readonly DataModel _data;

        public PitStopModel(DataModel telemetry)
        {
            _data = telemetry;
        }

        /// <summary>
        /// Players car pit service status bits
        /// </summary>
        public PitServiceStatus ServiceStatus => (PitServiceStatus)_data.PlayerCarPitSvStatus;

        /// <summary>
        /// Pitstop fast repair set
        /// </summary>
        public float FastRepair => _data.dpFastRepair;

        /// <summary>
        /// Pitstop fuel add ammount
        /// </summary>
        public float FuelAddKg => _data.dpFuelAddKg;

        /// <summary>
        /// Pitstop fuel fill flag
        /// </summary>
        public float FuelFill => _data.dpFuelFill;

        /// <summary>
        /// Pitstop left front tire change request
        /// </summary>
        public float LeftFrontTireChange => _data.dpLFTireChange;

        /// <summary>
        /// Pitstop left front tire cold pressure adjustment
        /// </summary>
        public float LeftFrontTireColdPressure => _data.dpLFTireColdPress;

        /// <summary>
        /// Pitstop left rear tire change request
        /// </summary>
        public float LeftRearTireChange => _data.dpLRTireChange;

        /// <summary>
        /// Pitstop left rear tire cold pressure adjustment
        /// </summary>
        public float LeftRearTireColdPressure => _data.dpLRTireColdPress;

        /// <summary>
        /// Pitstop right front tire change request
        /// </summary>
        public float RightFrontTireChange => _data.dpRFTireChange;

        /// <summary>
        /// Pitstop right front cold tire pressure adjustment
        /// </summary>
        public float RightFrontColdPressure => _data.dpRFTireColdPress;

        /// <summary>
        /// Pitstop right rear tire change request
        /// </summary>
        public float RightRearTireChange => _data.dpRRTireChange;

        /// <summary>
        /// Pitstop right rear cold tire pressure adjustment
        /// </summary>
        public float RightRearTireColdPressure => _data.dpRRTireColdPress;

        /// <summary>
        /// Pitstop windshield tearoff
        /// </summary>
        public float WindshieldTearoff => _data.dpWindshieldTearoff;

        /// <summary>
        /// Time left for optional repairs if repairs are active
        /// </summary>
        public TimeSpan OptionalRepairLeft => TimeSpan.FromSeconds(_data.PitOptRepairLeft);

        /// <summary>
        /// Time left for mandatory pit repairs if repairs are active
        /// </summary>
        public TimeSpan RepairLeft => TimeSpan.FromSeconds(_data.PitRepairLeft);

        /// <summary>
        /// Is the player getting pit stop service
        /// </summary>
        public bool PitstopActive => _data.PitstopActive;

        /// <summary>
        /// Bitfield of pit service checkboxes
        /// </summary>
        public PitServiceFlags ServiceFlags => (PitServiceFlags)_data.PitSvFlags;

        /// <summary>
        /// Pit service fuel add amount
        /// </summary>
        public float ServiceFuelAmount => _data.PitSvFuel;

        /// <summary>
        /// Pit service left front tire pressure
        /// </summary>
        public float ServiceLeftFrontTirePressure => _data.PitSvLFP;

        /// <summary>
        /// Pit service left rear tire pressure
        /// </summary>
        public float ServiceLeftRearTirePressure => _data.PitSvLRP;

        /// <summary>
        /// Pit service right front tire pressure
        /// </summary>
        public float ServiceRightFrontTirePressure => _data.PitSvRFP;

        /// <summary>
        /// Pit service right rear tire pressure
        /// </summary>
        public float PitServiceRightRearTirePressure => _data.PitSvRRP;

        /// <summary>
        /// Pit service pending tire compound
        /// </summary>
        public int ServiceTireCompound => _data.PitSvTireCompound;
    }
}
