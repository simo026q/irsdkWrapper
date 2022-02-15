using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkWrapper.Libary.Models.Telemetry.Drivers;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public class TelemetryInfo
    {
        public CameraInfo Camera { get; private set; }
        public DriverInfo Driver { get; private set; }
        public ReplayInfo Replay { get; private set; }
        public SessionInfo Session { get; private set; }
        public SimInfo Sim { get; private set; }
        public TrackConditions TrackConditions { get; private set; }

        public TelemetryInfo(byte[] data, Dictionary<string, VarHeader> headers)
        {
            Camera = new CameraInfo(data, headers);
            Driver = new DriverInfo(data, headers);
            Replay = new ReplayInfo(data, headers);
            Session = new SessionInfo(data, headers);
            Sim = new SimInfo(data, headers);
            TrackConditions = new TrackConditions(data, headers);
        }
    }
}
