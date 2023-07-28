using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28JulyAssignment18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        private bool isConnected;
        private int batteryLevel;

        public Laptop()
        {
            isConnected = false;
            batteryLevel = 0;
        }

        public bool Connect()
        {
            isConnected = true;
            Console.WriteLine("Laptop connected!");
            return isConnected;
        }

        public void Charge(int minutes)
        {
            batteryLevel += minutes;
            Console.WriteLine($"Laptop charged for {minutes} minutes.");
        }

        public string Display()
        {
            return "Laptop: Battery Level = " + batteryLevel + "%";
        }
    }
}
