using irsdkSharp.Models;
using System;
using System.Collections.Generic;

namespace irsdkSharp.Test.Serialization.Models.Data
{
    public class DataModel
    {
        private readonly byte[] _data;
        private readonly Dictionary<string, VarHeader> _headers;

        public DataModel(byte[] data, Dictionary<string, VarHeader> headers)
        {
            _data = data;
            _headers = headers;
        }

        private CarModel[] _cars;
        public CarModel[] Cars
        {
            get
            {
                if (_cars == null)
                {
                    _cars = new CarModel[64];
                    for (var i = 0; i < _cars.Length; i++)
                    {
                        Cars[i] = new CarModel(i, _data, _headers);
                    }
                }
                return _cars;
            }
        }

        public int CarLeftRight => ValueSerializer.GetIntValue(nameof(CarLeftRight), _data, _headers);

        public int DCDriversSoFar => ValueSerializer.GetIntValue(nameof(DCDriversSoFar), _data, _headers);

        public int DCLapStatus => ValueSerializer.GetIntValue(nameof(DCLapStatus), _data, _headers);

        public bool dcStarter => ValueSerializer.GetBoolValue(nameof(dcStarter), _data, _headers);

        public float dpFastRepair => ValueSerializer.GetFloatValue(nameof(dpFastRepair), _data, _headers);

        public float dpFuelAddKg => ValueSerializer.GetFloatValue(nameof(dpFuelAddKg), _data, _headers);

        public float dpFuelFill => ValueSerializer.GetFloatValue(nameof(dpFuelFill), _data, _headers);

        public float dpLFTireChange => ValueSerializer.GetFloatValue(nameof(dpLFTireChange), _data, _headers);

        public float dpLFTireColdPress => ValueSerializer.GetFloatValue(nameof(dpLFTireColdPress), _data, _headers);

        public float dpLRTireChange => ValueSerializer.GetFloatValue(nameof(dpLRTireChange), _data, _headers);

        public float dpLRTireColdPress => ValueSerializer.GetFloatValue(nameof(dpLRTireColdPress), _data, _headers);

        public float dpRFTireChange => ValueSerializer.GetFloatValue(nameof(dpRFTireChange), _data, _headers);

        public float dpRFTireColdPress => ValueSerializer.GetFloatValue(nameof(dpRFTireColdPress), _data, _headers);

        public float dpRRTireChange => ValueSerializer.GetFloatValue(nameof(dpRRTireChange), _data, _headers);

        public float dpRRTireColdPress => ValueSerializer.GetFloatValue(nameof(dpRRTireColdPress), _data, _headers);

        public float dpWindshieldTearoff => ValueSerializer.GetFloatValue(nameof(dpWindshieldTearoff), _data, _headers);

        public bool DriverMarker => ValueSerializer.GetBoolValue(nameof(DriverMarker), _data, _headers);

        public int EnterExitReset => ValueSerializer.GetIntValue(nameof(EnterExitReset), _data, _headers);

        public int Lap => ValueSerializer.GetIntValue(nameof(Lap), _data, _headers);

        public int LapBestLap => ValueSerializer.GetIntValue(nameof(LapBestLap), _data, _headers);

        public float LapBestLapTime => ValueSerializer.GetFloatValue(nameof(LapBestLapTime), _data, _headers);

        public int LapBestNLapLap => ValueSerializer.GetIntValue(nameof(LapBestNLapLap), _data, _headers);

        public float LapBestNLapTime => ValueSerializer.GetFloatValue(nameof(LapBestNLapTime), _data, _headers);

        public int LapCompleted => ValueSerializer.GetIntValue(nameof(LapCompleted), _data, _headers);

        public float LapCurrentLapTime => ValueSerializer.GetFloatValue(nameof(LapCurrentLapTime), _data, _headers);

        public float LapDeltaToBestLap => ValueSerializer.GetFloatValue(nameof(LapDeltaToBestLap), _data, _headers);

        public float LapDeltaToBestLap_DD => ValueSerializer.GetFloatValue(nameof(LapDeltaToBestLap_DD), _data, _headers);

        public bool LapDeltaToBestLap_OK => ValueSerializer.GetBoolValue(nameof(LapDeltaToBestLap_OK), _data, _headers);

        public float LapDeltaToOptimalLap => ValueSerializer.GetFloatValue(nameof(LapDeltaToOptimalLap), _data, _headers);

        public float LapDeltaToOptimalLap_DD => ValueSerializer.GetFloatValue(nameof(LapDeltaToOptimalLap_DD), _data, _headers);

        public bool LapDeltaToOptimalLap_OK => ValueSerializer.GetBoolValue(nameof(LapDeltaToOptimalLap_OK), _data, _headers);

        public float LapDeltaToSessionBestLap => ValueSerializer.GetFloatValue(nameof(LapDeltaToSessionBestLap), _data, _headers);

        public float LapDeltaToSessionBestLap_DD => ValueSerializer.GetFloatValue(nameof(LapDeltaToSessionBestLap_DD), _data, _headers);

        public bool LapDeltaToSessionBestLap_OK => ValueSerializer.GetBoolValue(nameof(LapDeltaToSessionBestLap_OK), _data, _headers);

        public float LapDeltaToSessionLastlLap => ValueSerializer.GetFloatValue(nameof(LapDeltaToSessionLastlLap), _data, _headers);

        public float LapDeltaToSessionLastlLap_DD => ValueSerializer.GetFloatValue(nameof(LapDeltaToSessionLastlLap_DD), _data, _headers);

        public bool LapDeltaToSessionLastlLap_OK => ValueSerializer.GetBoolValue(nameof(LapDeltaToSessionLastlLap_OK), _data, _headers);

        public float LapDeltaToSessionOptimalLap => ValueSerializer.GetFloatValue(nameof(LapDeltaToSessionOptimalLap), _data, _headers);

        public float LapDeltaToSessionOptimalLap_DD => ValueSerializer.GetFloatValue(nameof(LapDeltaToSessionOptimalLap_DD), _data, _headers);

        public bool LapDeltaToSessionOptimalLap_OK => ValueSerializer.GetBoolValue(nameof(LapDeltaToSessionOptimalLap_OK), _data, _headers);

        public float LapDist => ValueSerializer.GetFloatValue(nameof(LapDist), _data, _headers);

        public float LapDistPct => ValueSerializer.GetFloatValue(nameof(LapDistPct), _data, _headers);

        public int LapLasNLapSeq => ValueSerializer.GetIntValue(nameof(LapLasNLapSeq), _data, _headers);

        public float LapLastLapTime => ValueSerializer.GetFloatValue(nameof(LapLastLapTime), _data, _headers);

        public float LapLastNLapTime => ValueSerializer.GetFloatValue(nameof(LapLastNLapTime), _data, _headers);

        public bool LoadNumTextures => ValueSerializer.GetBoolValue(nameof(LoadNumTextures), _data, _headers);

        public bool OkToReloadTextures => ValueSerializer.GetBoolValue(nameof(OkToReloadTextures), _data, _headers);

        public float PitOptRepairLeft => ValueSerializer.GetFloatValue(nameof(PitOptRepairLeft), _data, _headers);

        public float PitRepairLeft => ValueSerializer.GetFloatValue(nameof(PitRepairLeft), _data, _headers);

        public bool PitsOpen => ValueSerializer.GetBoolValue(nameof(PitsOpen), _data, _headers);

        public bool PitstopActive => ValueSerializer.GetBoolValue(nameof(PitstopActive), _data, _headers);

        public int PitSvFlags => ValueSerializer.GetIntValue(nameof(PitSvFlags), _data, _headers);

        public float PitSvFuel => ValueSerializer.GetFloatValue(nameof(PitSvFuel), _data, _headers);

        public float PitSvLFP => ValueSerializer.GetFloatValue(nameof(PitSvLFP), _data, _headers);

        public float PitSvLRP => ValueSerializer.GetFloatValue(nameof(PitSvLRP), _data, _headers);

        public float PitSvRFP => ValueSerializer.GetFloatValue(nameof(PitSvRFP), _data, _headers);

        public float PitSvRRP => ValueSerializer.GetFloatValue(nameof(PitSvRRP), _data, _headers);

        public int PlayerCarClassPosition => ValueSerializer.GetIntValue(nameof(PlayerCarClassPosition), _data, _headers);

        public int PlayerCarDriverIncidentCount => ValueSerializer.GetIntValue(nameof(PlayerCarDriverIncidentCount), _data, _headers);

        public int PlayerCarIdx => ValueSerializer.GetIntValue(nameof(PlayerCarIdx), _data, _headers);

        public bool PlayerCarInPitStall => ValueSerializer.GetBoolValue(nameof(PlayerCarInPitStall), _data, _headers);

        public int PlayerCarMyIncidentCount => ValueSerializer.GetIntValue(nameof(PlayerCarMyIncidentCount), _data, _headers);

        public int PlayerCarPitSvStatus => ValueSerializer.GetIntValue(nameof(PlayerCarPitSvStatus), _data, _headers);

        public int PlayerCarPosition => ValueSerializer.GetIntValue(nameof(PlayerCarPosition), _data, _headers);

        public float PlayerCarPowerAdjust => ValueSerializer.GetFloatValue(nameof(PlayerCarPowerAdjust), _data, _headers);

        public int PlayerCarTeamIncidentCount => ValueSerializer.GetIntValue(nameof(PlayerCarTeamIncidentCount), _data, _headers);

        public float PlayerCarTowTime => ValueSerializer.GetFloatValue(nameof(PlayerCarTowTime), _data, _headers);

        public float PlayerCarWeightPenalty => ValueSerializer.GetFloatValue(nameof(PlayerCarWeightPenalty), _data, _headers);

        public int PlayerTrackSurface => ValueSerializer.GetIntValue(nameof(PlayerTrackSurface), _data, _headers);

        public int PlayerTrackSurfaceMaterial => ValueSerializer.GetIntValue(nameof(PlayerTrackSurfaceMaterial), _data, _headers);

        public int RaceLaps => ValueSerializer.GetIntValue(nameof(RaceLaps), _data, _headers);

        public int RadioTransmitCarIdx => ValueSerializer.GetIntValue(nameof(RadioTransmitCarIdx), _data, _headers);

        public int RadioTransmitFrequencyIdx => ValueSerializer.GetIntValue(nameof(RadioTransmitFrequencyIdx), _data, _headers);

        public int RadioTransmitRadioIdx => ValueSerializer.GetIntValue(nameof(RadioTransmitRadioIdx), _data, _headers);

        public float TireLF_RumblePitch => ValueSerializer.GetFloatValue(nameof(TireLF_RumblePitch), _data, _headers);

        public float TireLR_RumblePitch => ValueSerializer.GetFloatValue(nameof(TireLR_RumblePitch), _data, _headers);

        public float TireRF_RumblePitch => ValueSerializer.GetFloatValue(nameof(TireRF_RumblePitch), _data, _headers);

        public float TireRR_RumblePitch => ValueSerializer.GetFloatValue(nameof(TireRR_RumblePitch), _data, _headers);
    }
}