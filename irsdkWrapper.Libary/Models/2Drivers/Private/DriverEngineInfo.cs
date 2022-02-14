using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkSharp.Serialization;
using irsdkSharp.Serialization.Enums.Fastest;
using irsdkSharp.Models;

namespace irsdkWrapper.Libary.Models.Drivers.Private
{
    public class DriverEngineInfo
    {
        #region Fields
        private readonly byte[] _data;
        private readonly Dictionary<string, VarHeader> _headers;

        private float? _fuelCapacity;
        #endregion

        #region Contructor
        public DriverEngineInfo(byte[] data, Dictionary<string, VarHeader> headers)
        {
            _data = data;
            _headers = headers;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Engine warning lights
        /// </summary>
        public EngineWarnings EngineWarnings => (EngineWarnings)ValueSerializer.GetIntValue(nameof(EngineWarnings), _data, _headers);

        /// <summary>
        /// Liters of fuel remaining
        /// </summary>
        /// <value>Liters</value>
        public float FuelLevel => ValueSerializer.GetFloatValue(nameof(FuelLevel), _data, _headers);

        /// <summary>
        /// Percent fuel remaining
        /// </summary>
        /// <value>Percentage</value>
        public float FuelLevelPct => ValueSerializer.GetFloatValue(nameof(FuelLevelPct), _data, _headers);

        /// <summary>
        /// Engine fuel pressure
        /// </summary>
        /// <value>Bar</value>
        public float FuelPress => ValueSerializer.GetFloatValue(nameof(FuelPress), _data, _headers);

        /// <summary>
        /// Engine fuel used instantaneous
        /// </summary>
        /// <value>Kilogram per hour</value>
        public float FuelUsePerHour => ValueSerializer.GetFloatValue(nameof(FuelUsePerHour), _data, _headers);

        /// <summary>
        /// Total capacity of fuel tank 
        /// </summary>
        /// <value>Liters</value>
        public float FuelCapacity
        {
            get
            {
                _fuelCapacity ??= FuelLevel / _fuelCapacity;
                float capacity = (float)_fuelCapacity;
                return float.IsNaN(capacity) ? 0f : capacity;
            }
        }

        /// <summary>
        /// Engine manifold pressure
        /// </summary>
        /// <value>Bar</value>
        public float ManifoldPress => ValueSerializer.GetFloatValue(nameof(ManifoldPress), _data, _headers);

        /// <summary>
        /// Engine oil level
        /// </summary>
        /// <value>Liters</value>
        public float OilLevel => ValueSerializer.GetFloatValue(nameof(OilLevel), _data, _headers);

        /// <summary>
        /// Engine oil pressure
        /// </summary>
        /// <value>Bar</value>
        public float OilPress => ValueSerializer.GetFloatValue(nameof(OilPress), _data, _headers);

        /// <summary>
        /// Engine oil temperature
        /// </summary>
        /// <value>Celcius</value>
        public float OilTemp => ValueSerializer.GetFloatValue(nameof(OilTemp), _data, _headers);

        /// <summary>
        /// Engine rpm
        /// </summary>
        /// <value>revs/min</value>
        public float RPM => ValueSerializer.GetFloatValue(nameof(RPM), _data, _headers);

        /// <summary>
        /// RPM of shifter grinding noise
        /// </summary>
        /// <value>RPM</value>
        public float ShiftGrindRPM => ValueSerializer.GetFloatValue(nameof(ShiftGrindRPM), _data, _headers);

        // DEPRECATED use DriverCarSLBlinkRPM instead
        // public float ShiftIndicatorPct => ValueSerializer.GetFloatValue(nameof(ShiftIndicatorPct), _data, _headers);

        /// <summary>
        /// Friction torque applied to gears when shifting or grinding
        /// </summary>
        /// <value>Percentage</value>
        public float ShiftPowerPct => ValueSerializer.GetFloatValue(nameof(ShiftPowerPct), _data, _headers);

        /// <summary>
        /// Engine voltage
        /// </summary>
        /// <value>Volt</value>
        public float Voltage => ValueSerializer.GetFloatValue(nameof(Voltage), _data, _headers);

        /// <summary>
        /// Engine coolant level
        /// </summary>
        /// <value>Liters</value>
        public float WaterLevel => ValueSerializer.GetFloatValue(nameof(WaterLevel), _data, _headers);

        /// <summary>
        /// Engine coolant temperature
        /// </summary>
        /// <value>Celcius</value>
        public float WaterTemp => ValueSerializer.GetFloatValue(nameof(WaterTemp), _data, _headers);
        #endregion

        #region Methods
        /// <summary>
        /// Get the total amount of stints
        /// </summary>
        /// <param name="lapFuel">Average liters of fuel used per lap</param>
        /// <param name="totalLaps">Total amount of laps driven</param>
        /// <returns>Total stints</returns>
        public int GetTotalStints(float lapFuel, int totalLaps)
        {
            double exactStints = GetFuelRequired(lapFuel, totalLaps) / FuelCapacity;
            int realStints = (int)Math.Ceiling(exactStints);
            return realStints;
        }

        /// <summary>
        /// Get the total amount of laps in a full stint
        /// </summary>
        /// <param name="lapFuel">Average liters of fuel used per lap</param>
        /// <returns>Total laps</returns>
        public int GetFullStintLaps(float lapFuel)
        {
            return (int)Math.Floor(FuelCapacity / lapFuel);
        }

        /// <summary>
        /// Get the total liters of fuel required to finish the amount of <paramref name="totalLaps"/>
        /// </summary>
        /// <param name="lapFuel">Average liters of fuel used per lap</param>
        /// <param name="totalLaps">Total amount of laps driven</param>
        /// <returns>Liters of fuel</returns>
        public static float GetFuelRequired(float lapFuel, int totalLaps)
        {
            return lapFuel * totalLaps;
        }
        #endregion
    }
}
