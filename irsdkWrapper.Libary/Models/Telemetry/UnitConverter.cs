using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using irsdkWrapper.Enums;

namespace irsdkWrapper.Models.Telemetry
{
    public static class UnitConverter
    {
        public static float RadiansToDegrees(float radians)
        {
            return NormalizeDegrees((float)(radians * 180f / Math.PI));
        }

        public static float DegreesToRadians(float degrees)
        {
            return (float)(NormalizeDegrees(degrees) * Math.PI / 180f);
        }

        public static CardinalDirection DegreesToCardinalDirection(float degrees)
        {
            int direction = (int)Math.Round(NormalizeDegrees(degrees) / 45f);

            return (CardinalDirection)direction;
        }

        public static float NormalizeDegrees(float degrees)
        {
            while (degrees < 0f) degrees += 360f;
            while (degrees > 360f) degrees -= 360f;
            return degrees;
        }

        public static float MsToKph(float ms)
        {
            return ms * 3.6f;
        }

        public static float MsToMph(float ms)
        {
            return ms * 2.23694f;
        }

        public static float CelsiusToFahrenheit(float celsius)
        {
            return (celsius * 1.8f) + 32;
        }

        public static float FahrenheitToCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) / 1.8f;
        }
    }
}
