using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class VehicleFactory
    {
        public IVehicle GetVehicle(string numOfWheels)
        {
            
            switch (numOfWheels.ToLower())
            {
                case "two":
                    return new Motorcycle();
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                case "four":
                    return new Car();
                default:
                    Console.WriteLine("Not recognisable");
                    return new Car();
                    
            }

        }
    }
}
