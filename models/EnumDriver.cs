using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_30_a_strings.models
{
    public static class EnumDriver
    {
        public static void Run()
        {
            CallTrafficLight();
            DayOfWeekDemo();
        }

        public static void DayOfWeekDemo()
        {
            Console.WriteLine($"Today is {DayOfWeek.Wednesday} | {(int) DayOfWeek.Wednesday}");
        }

        public static void CallTrafficLight()
        {
            Console.WriteLine($"Traffic Light: {ProcessTrafficLight(TrafficLightState.Green)}");
            Console.WriteLine($"Traffic Light: {ProcessTrafficLight(TrafficLightState.Unknown)}");
        }

        public static string ProcessTrafficLight(TrafficLightState state)
        {
            string message = state switch
            {
                TrafficLightState.Red => "Stop",
                TrafficLightState.Yellow => "Caution",
                TrafficLightState.Green => "Go",
                _ => "Traffic light is out of action, proceed with caution"

            };

            return message;
        }

    }
}
