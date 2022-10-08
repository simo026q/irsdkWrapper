using System;
using irsdkWrapper;
using irsdkWrapper.Models.Telemetry;
using irsdkSharp.Serialization.Models.Data;
using irsdkSharp.Serialization.Models.Session;

namespace irsdkWrapper.TestConsole
{
    internal class Program
    {
        private static SdkWrapper _wrapper = new SdkWrapper(true);

        static void Main(string[] args)
        {
            _wrapper.TelemetryUpdated += OnTelemetryUpdated;
            _wrapper.SessionInfoUpdated += OnSessionInfoUpdated;

            DisplayData();

            Console.ReadLine();
        }

        static void OnTelemetryUpdated(object? sender, TelemetryData e)
        {
            DisplayData();
        }

        static void OnSessionInfoUpdated(object? sender, IRacingSessionModel e)
        {
            DisplayData();
        }

        static void DisplayData()
        {
        }
    }
}