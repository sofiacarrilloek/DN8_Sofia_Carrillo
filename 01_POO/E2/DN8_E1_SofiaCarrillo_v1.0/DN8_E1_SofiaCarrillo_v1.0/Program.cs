using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace DN8_E1_SofiaCarrillo_v1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                String TypeCar = null;
                Vehicles vehicle = null;

                Console.WriteLine("Type the vehicle: ");
                TypeCar = Console.ReadLine().ToLower();


                switch (TypeCar)
                {
                    case "car":
                        vehicle = new Car();
                        break;

                    case "truck":
                        vehicle = new Truck();
                        break;

                    case "train":
                        vehicle = new Train();
                        break;

                    default:
                        Console.WriteLine("Vehicle not found");
                        break;
                }

                if (vehicle != null)
                {
                    vehicle.VehiclesSound();

                }

            }
        }
    }
}
