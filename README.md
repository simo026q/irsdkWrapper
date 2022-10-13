# What is irsdkWrapper?
irsdkWrapper is wrapper for the [irsdkSharp](https://github.com/SlevinthHeaven/irsdkSharp) repository with serialization.
This is an alternative to [iRacingSdkWrapper](https://github.com/NickThissen/iRacingSdkWrapper) with the goal to make it use less resources and have the latest telemetry data.

# Version
[![NuGet](https://img.shields.io/nuget/vpre/irsdkWrapper?style=flat-square)](https://www.nuget.org/packages/irsdkWrapper/)

# Basic usage
```csharp
using System;
using irsdkWrapper;
using irsdkWrapper.Models.Session;
using irsdkWrapper.Models.Telemetry;

namespace irsdkWrapper.TestConsole
{
    internal class Program
    {
        // The SdkWrapper instance
        private static SdkWrapper _wrapper = new SdkWrapper();

        // You can easily inject a ILogger like this:
        // private static SdkWrapper _wrapper = new SdkWrapper(_logger);

        static void Main(string[] args)
        {
            // Add event handlers
            _wrapper.Connected += OnConnected;
            _wrapper.Disconnected += OnDisconnected;
            _wrapper.TelemetryUpdated += OnTelemetryUpdated;
            _wrapper.SessionInfoUpdated += OnSessionInfoUpdated;

            // Update FPS (1-60) (Default is 10)
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
        static void OnSessionInfoUpdated(object? sender, SessionInfo e)
        {
            // Your code
        }
    }
}
```