using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Enums.Fastest;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public class DriverInfo : TelemetryModel
    {
        public DriverInfo(byte[] data, Dictionary<string, VarHeader> headers) : base(data, headers) { }

        public float Brake => ValueSerializer.GetFloatValue(nameof(Brake), _data, _headers);

        public float BrakeRaw => ValueSerializer.GetFloatValue(nameof(BrakeRaw), _data, _headers);

        public float Clutch => ValueSerializer.GetFloatValue(nameof(Clutch), _data, _headers);

        public EngineWarnings EngineWarnings => (EngineWarnings)ValueSerializer.GetIntValue(nameof(EngineWarnings), _data, _headers);

        public int FastRepairAvailable => ValueSerializer.GetIntValue(nameof(FastRepairAvailable), _data, _headers);

        public int FastRepairUsed => ValueSerializer.GetIntValue(nameof(FastRepairUsed), _data, _headers);

        public float FuelLevel => ValueSerializer.GetFloatValue(nameof(FuelLevel), _data, _headers);

        public float FuelLevelPct => ValueSerializer.GetFloatValue(nameof(FuelLevelPct), _data, _headers);

        public float FuelPress => ValueSerializer.GetFloatValue(nameof(FuelPress), _data, _headers);

        public float FuelUsePerHour => ValueSerializer.GetFloatValue(nameof(FuelUsePerHour), _data, _headers);

        public int Gear => ValueSerializer.GetIntValue(nameof(Gear), _data, _headers);

        public float HandbrakeRaw => ValueSerializer.GetFloatValue(nameof(HandbrakeRaw), _data, _headers);

        public bool IsInGarage => ValueSerializer.GetBoolValue(nameof(IsInGarage), _data, _headers);

        public bool IsOnTrack => ValueSerializer.GetBoolValue(nameof(IsOnTrack), _data, _headers);

        public bool IsOnTrackCar => ValueSerializer.GetBoolValue(nameof(IsOnTrackCar), _data, _headers);

        public bool IsOnPitRoad => ValueSerializer.GetBoolValue("OnPitRoad", _data, _headers);

        public bool IsReplayPlaying => ValueSerializer.GetBoolValue(nameof(IsReplayPlaying), _data, _headers);

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

        public float Speed => ValueSerializer.GetFloatValue(nameof(Speed), _data, _headers);

        public float SteeringWheelAngle => ValueSerializer.GetFloatValue(nameof(SteeringWheelAngle), _data, _headers);

        public float SteeringWheelAngleMax => ValueSerializer.GetFloatValue(nameof(SteeringWheelAngleMax), _data, _headers);

        public float SteeringWheelMaxForceNm => ValueSerializer.GetFloatValue(nameof(SteeringWheelMaxForceNm), _data, _headers);

        public float SteeringWheelPctDamper => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctDamper), _data, _headers);

        public float SteeringWheelPctTorque => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctTorque), _data, _headers);

        public float SteeringWheelPctTorqueSign => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctTorqueSign), _data, _headers);

        public float SteeringWheelPctTorqueSignStops => ValueSerializer.GetFloatValue(nameof(SteeringWheelPctTorqueSignStops), _data, _headers);

        public float SteeringWheelPeakForceNm => ValueSerializer.GetFloatValue(nameof(SteeringWheelPeakForceNm), _data, _headers);

        public float SteeringWheelTorque => ValueSerializer.GetFloatValue(nameof(SteeringWheelTorque), _data, _headers);

        public float[] SteeringWheelTorque_ST => ValueSerializer.GetFloatArrayValue(nameof(SteeringWheelTorque_ST), _data, _headers);

        public bool SteeringWheelUseLinear => ValueSerializer.GetBoolValue(nameof(SteeringWheelUseLinear), _data, _headers);

        public float Throttle => ValueSerializer.GetFloatValue(nameof(Throttle), _data, _headers);

        public float ThrottleRaw => ValueSerializer.GetFloatValue(nameof(ThrottleRaw), _data, _headers);

        public float Voltage => ValueSerializer.GetFloatValue(nameof(Voltage), _data, _headers);

        public float WaterLevel => ValueSerializer.GetFloatValue(nameof(WaterLevel), _data, _headers);

        public float WaterTemp => ValueSerializer.GetFloatValue(nameof(WaterTemp), _data, _headers);

        public float VelocityX => ValueSerializer.GetFloatValue(nameof(VelocityX), _data, _headers);

        public float[] VelocityX_ST => ValueSerializer.GetFloatArrayValue(nameof(VelocityX_ST), _data, _headers);

        public float VelocityY => ValueSerializer.GetFloatValue(nameof(VelocityY), _data, _headers);

        public float[] VelocityY_ST => ValueSerializer.GetFloatArrayValue(nameof(VelocityY_ST), _data, _headers);

        public float VelocityZ => ValueSerializer.GetFloatValue(nameof(VelocityZ), _data, _headers);

        public float[] VelocityZ_ST => ValueSerializer.GetFloatArrayValue(nameof(VelocityZ_ST), _data, _headers);

        public float VertAccel => ValueSerializer.GetFloatValue(nameof(VertAccel), _data, _headers);

        public float[] VertAccel_ST => ValueSerializer.GetFloatArrayValue(nameof(VertAccel_ST), _data, _headers);

        public float Yaw => ValueSerializer.GetFloatValue(nameof(Yaw), _data, _headers);

        public float YawNorth => ValueSerializer.GetFloatValue(nameof(YawNorth), _data, _headers);

        public float YawRate => ValueSerializer.GetFloatValue(nameof(YawRate), _data, _headers);

        public float[] YawRate_ST => ValueSerializer.GetFloatArrayValue(nameof(YawRate_ST), _data, _headers);

        public float RFbrakeLinePress => ValueSerializer.GetFloatValue(nameof(RFbrakeLinePress), _data, _headers);

        public float RFcoldPressure => ValueSerializer.GetFloatValue(nameof(RFcoldPressure), _data, _headers);

        public float RFshockDefl => ValueSerializer.GetFloatValue(nameof(RFshockDefl), _data, _headers);

        public float[] RFshockDefl_ST => ValueSerializer.GetFloatArrayValue(nameof(RFshockDefl_ST), _data, _headers);

        public float RFshockVel => ValueSerializer.GetFloatValue(nameof(RFshockVel), _data, _headers);

        public float[] RFshockVel_ST => ValueSerializer.GetFloatArrayValue(nameof(RFshockVel_ST), _data, _headers);

        public float RFtempCL => ValueSerializer.GetFloatValue(nameof(RFtempCL), _data, _headers);

        public float RFtempCM => ValueSerializer.GetFloatValue(nameof(RFtempCM), _data, _headers);

        public float RFtempCR => ValueSerializer.GetFloatValue(nameof(RFtempCR), _data, _headers);

        public float RFwearL => ValueSerializer.GetFloatValue(nameof(RFwearL), _data, _headers);

        public float RFwearM => ValueSerializer.GetFloatValue(nameof(RFwearM), _data, _headers);

        public float RFwearR => ValueSerializer.GetFloatValue(nameof(RFwearR), _data, _headers);

        public float Roll => ValueSerializer.GetFloatValue(nameof(Roll), _data, _headers);

        public float RollRate => ValueSerializer.GetFloatValue(nameof(RollRate), _data, _headers);

        public float[] RollRate_ST => ValueSerializer.GetFloatArrayValue(nameof(RollRate_ST), _data, _headers);

        public float RRbrakeLinePress => ValueSerializer.GetFloatValue(nameof(RRbrakeLinePress), _data, _headers);

        public float RRcoldPressure => ValueSerializer.GetFloatValue(nameof(RRcoldPressure), _data, _headers);

        public float RRshockDefl => ValueSerializer.GetFloatValue(nameof(RRshockDefl), _data, _headers);

        public float[] RRshockDefl_ST => ValueSerializer.GetFloatArrayValue(nameof(RRshockDefl_ST), _data, _headers);

        public float RRshockVel => ValueSerializer.GetFloatValue(nameof(RRshockVel), _data, _headers);

        public float[] RRshockVel_ST => ValueSerializer.GetFloatArrayValue(nameof(RRshockVel_ST), _data, _headers);

        public float RRtempCL => ValueSerializer.GetFloatValue(nameof(RRtempCL), _data, _headers);

        public float RRtempCM => ValueSerializer.GetFloatValue(nameof(RRtempCM), _data, _headers);

        public float RRtempCR => ValueSerializer.GetFloatValue(nameof(RRtempCR), _data, _headers);

        public float RRwearL => ValueSerializer.GetFloatValue(nameof(RRwearL), _data, _headers);

        public float RRwearM => ValueSerializer.GetFloatValue(nameof(RRwearM), _data, _headers);

        public float RRwearR => ValueSerializer.GetFloatValue(nameof(RRwearR), _data, _headers);

        public float LongAccel => ValueSerializer.GetFloatValue(nameof(LongAccel), _data, _headers);

        public float[] LongAccel_ST => ValueSerializer.GetFloatArrayValue(nameof(LongAccel_ST), _data, _headers);

        public float LRbrakeLinePress => ValueSerializer.GetFloatValue(nameof(LRbrakeLinePress), _data, _headers);

        public float LRcoldPressure => ValueSerializer.GetFloatValue(nameof(LRcoldPressure), _data, _headers);

        public float LRshockDefl => ValueSerializer.GetFloatValue(nameof(LRshockDefl), _data, _headers);

        public float[] LRshockDefl_ST => ValueSerializer.GetFloatArrayValue(nameof(LRshockDefl_ST), _data, _headers);

        public float LRshockVel => ValueSerializer.GetFloatValue(nameof(LRshockVel), _data, _headers);

        public float[] LRshockVel_ST => ValueSerializer.GetFloatArrayValue(nameof(LRshockVel_ST), _data, _headers);

        public float LRtempCL => ValueSerializer.GetFloatValue(nameof(LRtempCL), _data, _headers);

        public float LRtempCM => ValueSerializer.GetFloatValue(nameof(LRtempCM), _data, _headers);

        public float LRtempCR => ValueSerializer.GetFloatValue(nameof(LRtempCR), _data, _headers);

        public float LRwearL => ValueSerializer.GetFloatValue(nameof(LRwearL), _data, _headers);

        public float LRwearM => ValueSerializer.GetFloatValue(nameof(LRwearM), _data, _headers);

        public float LRwearR => ValueSerializer.GetFloatValue(nameof(LRwearR), _data, _headers);

        public float LatAccel => ValueSerializer.GetFloatValue(nameof(LatAccel), _data, _headers);

        public float[] LatAccel_ST => ValueSerializer.GetFloatArrayValue(nameof(LatAccel_ST), _data, _headers);

        public float LFbrakeLinePress => ValueSerializer.GetFloatValue(nameof(LFbrakeLinePress), _data, _headers);

        public float LFcoldPressure => ValueSerializer.GetFloatValue(nameof(LFcoldPressure), _data, _headers);

        public float LFshockDefl => ValueSerializer.GetFloatValue(nameof(LFshockDefl), _data, _headers);

        public float[] LFshockDefl_ST => ValueSerializer.GetFloatArrayValue(nameof(LFshockDefl_ST), _data, _headers);

        public float LFshockVel => ValueSerializer.GetFloatValue(nameof(LFshockVel), _data, _headers);

        public float[] LFshockVel_ST => ValueSerializer.GetFloatArrayValue(nameof(LFshockVel_ST), _data, _headers);

        public float LFtempCL => ValueSerializer.GetFloatValue(nameof(LFtempCL), _data, _headers);

        public float LFtempCM => ValueSerializer.GetFloatValue(nameof(LFtempCM), _data, _headers);

        public float LFtempCR => ValueSerializer.GetFloatValue(nameof(LFtempCR), _data, _headers);

        public float LFwearL => ValueSerializer.GetFloatValue(nameof(LFwearL), _data, _headers);

        public float LFwearM => ValueSerializer.GetFloatValue(nameof(LFwearM), _data, _headers);

        public float LFwearR => ValueSerializer.GetFloatValue(nameof(LFwearR), _data, _headers);

        public float Pitch => ValueSerializer.GetFloatValue(nameof(Pitch), _data, _headers);

        public float PitchRate => ValueSerializer.GetFloatValue(nameof(PitchRate), _data, _headers);

        public float[] PitchRate_ST => ValueSerializer.GetFloatArrayValue(nameof(PitchRate_ST), _data, _headers);
    }
}
