using irsdkWrapper.Enums;
using irsdkSharp.Enums;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Serialization.Models.Data;

namespace irsdkWrapper.Models.Telemetry
{
    public class UncategorizedData
    {
        private IRacingDataModel _telemetry;

        private DataModel _data => _telemetry.Data;

        public UncategorizedData(IRacingDataModel telemetry)
        {
            _telemetry = telemetry;
        }

        public CarLeftRight CarLeftRight => (CarLeftRight)_data.CarLeftRight;

        public int DCDriversSoFar => _data.DCDriversSoFar;

        public int DCLapStatus => _data.DCLapStatus;

        public bool dcStarter => _data.dcStarter;

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

        public EnterExitReset EnterExitReset => (EnterExitReset)_data.EnterExitReset;

        public int FastRepairAvailable => _data.FastRepairAvailable;

        public int FastRepairUsed => _data.FastRepairUsed;

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

        public float Pitch => _data.Pitch;

        public float PitchRate => _data.PitchRate;

        public float[] PitchRate_ST => _data.PitchRate_ST;

        public float PitOptRepairLeft => _data.PitOptRepairLeft;

        public float PitRepairLeft => _data.PitRepairLeft;

        public bool PitstopActive => _data.PitstopActive;

        public PitServiceFlags PitServiceFlags => (PitServiceFlags)_data.PitSvFlags;

        public float PitServiceFuel => _data.PitSvFuel;

        public float PitServiceLFP => _data.PitSvLFP;

        public float PitServiceLRP => _data.PitSvLRP;

        public float PitServiceRFP => _data.PitSvRFP;

        public float PitServiceRRP => _data.PitSvRRP;

        public int RadioTransmitCarIndex => _data.RadioTransmitCarIdx;

        public int RadioTransmitFrequencyIndex => _data.RadioTransmitFrequencyIdx;

        public int RadioTransmitRadioIndex => _data.RadioTransmitRadioIdx;

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

        public float TireLF_RumblePitch => _data.TireLF_RumblePitch;

        public float TireLR_RumblePitch => _data.TireLR_RumblePitch;

        public float TireRF_RumblePitch => _data.TireRF_RumblePitch;

        public float TireRR_RumblePitch => _data.TireRR_RumblePitch;

        public float VelocityX => _data.VelocityX;

        public float[] VelocityX_ST => _data.VelocityX_ST;

        public float VelocityY => _data.VelocityY;

        public float[] VelocityY_ST => _data.VelocityY_ST;

        public float VelocityZ => _data.VelocityZ;

        public float[] VelocityZ_ST => _data.VelocityZ_ST;

        public float VertAccel => _data.VertAccel;

        public float[] VertAccel_ST => _data.VertAccel_ST;

        public float Yaw => _data.Yaw;

        public float YawNorth => _data.YawNorth;

        public float YawRate => _data.YawRate;

        public float[] YawRate_ST => _data.YawRate_ST;
    }
}
