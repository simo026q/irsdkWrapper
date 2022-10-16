using System;
using irsdkWrapper;
using irsdkWrapper.Models.Session;
using irsdkWrapper.Models.Telemetry;
using irsdkSharp.Serialization.Models.Session;

namespace irsdkWrapper.TestConsole
{
    internal class Program
    {
        // The SdkWrapper instance
        private static readonly SdkWrapper _wrapper = new SdkWrapper();

        // You can easily inject a ILogger like this:
        // private static SdkWrapper _wrapper = new SdkWrapper(_logger);

        static void Main()
        {
            // Add event handlers
            _wrapper.Connected += OnConnected;
            _wrapper.Disconnected += OnDisconnected;
            _wrapper.TelemetryUpdated += OnTelemetryUpdated;
            _wrapper.SessionInfoUpdated += OnSessionInfoUpdated;

            // Update FPS (Default is 10)
            int updateFrequency = 1;

            // Start listening for updates
            _wrapper.Start(updateFrequency);

            Console.ReadLine();
        }

        // When the Sdk connects to iRacing (You join a session)
        static void OnConnected(object? sender, EventArgs e)
        {
            // Your code
        }

        // When the Sdk disconnects from iRacing (You leave a session)
        // This event is not raised when you stop/dispose the SdkWrapper
        static void OnDisconnected(object? sender, EventArgs e)
        {
            // Your code
        }

        // Live telemetry data from iRacing
        // The update rate is controlled by the UpdateFrequency
        // This is updated even though there are no changes
        static void OnTelemetryUpdated(object? sender, TelemetryData e)
        {
            // Your code
        }

        // Static session info from iRacing
        // Updated on session change or if any session is changed
        static void OnSessionInfoUpdated(object? sender, IRacingSessionModel e)
        {
            // Your code
        }
    }
}