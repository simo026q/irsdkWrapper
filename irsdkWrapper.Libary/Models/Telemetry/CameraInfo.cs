﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Models;
using irsdkSharp.Enums;
using irsdkSharp.Serialization;

namespace irsdkWrapper.Libary.Models.Telemetry
{
    public class CameraInfo : TelemetryModel
    {
        public CameraInfo(byte[] data, Dictionary<string, VarHeader> headers) : base(data, headers) { }

        public int CamCameraNumber => ValueSerializer.GetIntValue(nameof(CamCameraNumber), _data, _headers);

        public CameraState CamCameraState => (CameraState)ValueSerializer.GetIntValue(nameof(CamCameraState), _data, _headers);

        public int CamCarIdx => ValueSerializer.GetIntValue(nameof(CamCarIdx), _data, _headers);

        public int CamGroupNumber => ValueSerializer.GetIntValue(nameof(CamGroupNumber), _data, _headers);
    }
}
