using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class TelemetryData
    {
        private IRacingDataModel _telemetry;

        public TelemetryData(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public void Update(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;

            _track = null;
            _input = null;
            _vehicle = null;
            _session = null;
            _system = null;
            _driver = null;
            _replay = null;
            _uncategorized = null;
        }

        public IEnumerable<CarModel> Cars => _telemetry.Data.Cars;

        private TrackData? _track;
        public TrackData Track => _track ??= new TrackData(_telemetry);

        private InputData? _input;
        public InputData Input => _input ??= new InputData(_telemetry);

        private VehicleData? _vehicle;
        public VehicleData Vehicle => _vehicle ??= new VehicleData(_telemetry);

        private SessionData? _session;
        public SessionData Session => _session ??= new SessionData(_telemetry);

        private SystemData? _system;
        public SystemData System => _system ??= new SystemData(_telemetry);

        private DriverData? _driver;
        public DriverData Driver => _driver ??= new DriverData(_telemetry);

        private ReplayData? _replay;
        public ReplayData Replay => _replay ??= new ReplayData(_telemetry);

        private UncategorizedData? _uncategorized;
        public UncategorizedData Uncategorized => _uncategorized ??= new UncategorizedData(_telemetry);
    }
}
