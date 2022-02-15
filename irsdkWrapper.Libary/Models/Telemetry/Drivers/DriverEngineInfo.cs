using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Enums.Fastest;

namespace irsdkWrapper.Libary.Models.Telemetry.Drivers
{
    public class DriverEngineInfo : TelemetryModel
    {
        public DriverEngineInfo(byte[] data, Dictionary<string, VarHeader> headers) : base(data, headers) { }

        public EngineWarnings EngineWarnings => (EngineWarnings)ValueSerializer.GetIntValue(nameof(EngineWarnings), _data, _headers);

        public float FuelLevel => ValueSerializer.GetFloatValue(nameof(FuelLevel), _data, _headers);

        public float FuelLevelPct => ValueSerializer.GetFloatValue(nameof(FuelLevelPct), _data, _headers);

        public float FuelPress => ValueSerializer.GetFloatValue(nameof(FuelPress), _data, _headers);

        public float FuelUsePerHour => ValueSerializer.GetFloatValue(nameof(FuelUsePerHour), _data, _headers);

        public float ManifoldPress => ValueSerializer.GetFloatValue(nameof(ManifoldPress), _data, _headers);

        public bool ManualBoost => ValueSerializer.GetBoolValue(nameof(ManualBoost), _data, _headers);

        public bool ManualNoBoost => ValueSerializer.GetBoolValue(nameof(ManualNoBoost), _data, _headers);

        public float OilLevel => ValueSerializer.GetFloatValue(nameof(OilLevel), _data, _headers);

        public float OilPress => ValueSerializer.GetFloatValue(nameof(OilPress), _data, _headers);

        public float OilTemp => ValueSerializer.GetFloatValue(nameof(OilTemp), _data, _headers);

        public bool PushToPass => ValueSerializer.GetBoolValue(nameof(PushToPass), _data, _headers);

        public float RPM => ValueSerializer.GetFloatValue(nameof(RPM), _data, _headers);

        public float ShiftGrindRPM => ValueSerializer.GetFloatValue(nameof(ShiftGrindRPM), _data, _headers);

        public float ShiftIndicatorPct => ValueSerializer.GetFloatValue(nameof(ShiftIndicatorPct), _data, _headers);

        public float ShiftPowerPct => ValueSerializer.GetFloatValue(nameof(ShiftPowerPct), _data, _headers);

        public float Voltage => ValueSerializer.GetFloatValue(nameof(Voltage), _data, _headers);

        public float WaterLevel => ValueSerializer.GetFloatValue(nameof(WaterLevel), _data, _headers);

        public float WaterTemp => ValueSerializer.GetFloatValue(nameof(WaterTemp), _data, _headers);
    }
}
