using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Required trucks {0}", CalculateTrucks(5, 125)));
        }

        public static decimal CalculateTrucks(int hours, decimal sandVolume)
        {
            return sandVolume / hours;
        }
    }
}
