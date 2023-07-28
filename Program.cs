using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28JulyAssignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            smartphone.Connect();
            smartphone.Charge(60);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop();
            laptop.Connect();
            laptop.Charge(120);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}
