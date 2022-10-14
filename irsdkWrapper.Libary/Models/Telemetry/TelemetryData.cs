using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

using irsdkWrapper.Models.Telemetry.Driver;

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
            _session = null;
            _simData = null;
            _driver = null;
            _replay = null;
        }

        public IEnumerable<CarModel> Cars => _telemetry.Data.Cars;

        private TrackModel? _track;
        public TrackModel Track => _track ??= new TrackModel(_telemetry);

        private SessionModel? _session;
        public SessionModel Session => _session ??= new SessionModel(_telemetry);

        private SimDataModel? _simData;
        public SimDataModel SimData => _simData ??= new SimDataModel(_telemetry);

        private DriverModel? _driver;
        public DriverModel Driver => _driver ??= new DriverModel(_telemetry.Data);

        private ReplayModel? _replay;
        public ReplayModel Replay => _replay ??= new ReplayModel(_telemetry);
    }
}
