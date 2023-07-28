using _28JulyAssignment18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28JulyAssignment18
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        private bool isConnected;
        private int batteryLevel;

        public Smartphone()
        {
            isConnected = false;
            batteryLevel = 0;
        }

        public bool Connect()
        {
            isConnected = true;
            Console.WriteLine("Smartphone connected!");
            return isConnected;
        }

        public void Charge(int minutes)
        {
            batteryLevel += minutes;
            Console.WriteLine($"Smartphone charged for {minutes} minutes.");
        }

        public string Display()
        {
            return "Smartphone: Battery Level = " + batteryLevel + "%";
        }
    }
}