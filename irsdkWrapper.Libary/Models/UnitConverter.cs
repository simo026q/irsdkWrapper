using irsdkWrapper.Enums;

namespace irsdkWrapper.Models
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

        public static string CardinalDirectionShortName(CardinalDirection direction)
        {
            switch (direction)
            {
                case CardinalDirection.North: return "N";
                case CardinalDirection.NorthEast: return "NE";
                case CardinalDirection.East: return "E";
                case CardinalDirection.SouthEast: return "SE";
                case CardinalDirection.South: return "S";
                case CardinalDirection.SouthWest: return "SW";
                case CardinalDirection.West: return "W";
                case CardinalDirection.NorthWest: return "NW";

                default: return String.Empty;
            }
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

        public static float KphToMph(float kph)
        {
            return kph * 1.609344f;
        }

        public static float MphToKph(float mph)
        {
            return mph / 1.609344f;
        }

        public static float CelsiusToFahrenheit(float celsius)
        {
            return (celsius * 1.8f) + 32;
        }

        public static float FahrenheitToCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) / 1.8f;
        }

        public static float StringToFloat(string valueString, string removeString = "", float defaultValue = 0f)
        {
            float value;

            if (!String.IsNullOrEmpty(removeString)) valueString = valueString.Replace(removeString, "");

            if (!String.IsNullOrEmpty(valueString))
            {
                valueString = valueString.Replace(".", ",");
                bool success = float.TryParse(valueString, out value);
                if (success) return value;
            }

            return defaultValue;
        }
    }
}
