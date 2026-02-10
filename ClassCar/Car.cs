using System;
using System.Collections.Generic;
using System.Text;
using carProject;

namespace carProject
{
    public class Car
    {
        public static void CarInfo()
        {
            Console.WriteLine("Every car has 4 wheels.");
        }
        public string Brand { get; set; }
        public double Speed { get; set; }
        public void StartEngine()
        {
            Console.WriteLine($"Engine started for {Brand}.");
        }
        public void Accelerate (int increase)
        {
            Speed += increase;
            Console.WriteLine($"{Brand} is accelerating. Current speed: {Speed} km/h.");
        }
        public void StartAndDrive()
        {
            StartEngine();
            Accelerate(50);
        }
    }

}
