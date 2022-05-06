using PojazdyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PojazdyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> listVehicles = new List<Vehicle>();

            var amphibian = new Amphibian(new Engine(300, FuelType.Oil));
            var bicycle = new Bicycle();
            var boat = new Boat(1000);
            var car = new Car(new Engine(180, FuelType.Electric));
            var motorbike = new Motorbike(new Engine(200, FuelType.Lpg));
            var motorboat = new Motorboat(new Engine(500, FuelType.Oil), 1000);
            var plane = new Plane(new Engine(1000, FuelType.Gas));

            listVehicles.Add(amphibian);
            listVehicles.Add(bicycle);
            listVehicles.Add(boat);
            listVehicles.Add(car);
            listVehicles.Add(motorbike);
            listVehicles.Add(motorboat);
            listVehicles.Add(plane);

            Console.WriteLine("\n>>> Simulate <<<");
            Random rand = new Random();
            foreach (var obj in listVehicles)
            {
                obj.VehicleStart();
                for (int i = 0; i < 3; i++)
                {
                    if (rand.Next(0, 100) >= 50)
                        obj.VehicleAccelerate(rand.Next(obj.EnvironmentCurrent.SpeedMin, obj.EnvironmentCurrent.SpeedMax / 3));
                    else
                        obj.VehicleDecelerate(rand.Next(obj.EnvironmentCurrent.SpeedMin, obj.EnvironmentCurrent.SpeedMax / 3));
                }

                if (rand.Next(0, 100) >= 90)
                    obj.VehicleStop();
            }

            plane.VehicleTakeOff();
            plane.VehicleAccelerate(100);
            plane.VehicleLand();

            amphibian.VehicleGroundToWater();
            amphibian.VehicleWaterToGround();
            amphibian.VehicleAccelerate(100);

            Console.WriteLine("\n>>> Print in list order <<<");
            foreach (var obj in listVehicles)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n>>> Print only ground type <<<");
            foreach (var obj in listVehicles)
            {
                if (obj.Type == VehicleType.Ground)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("\n>>> Print only ground type <<<");
            foreach (var obj in listVehicles)
            {
                if (obj.Type == VehicleType.Ground)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("\n>>> Print sorted by speed ascending <<<");
            var orderBySpeedAscending = from obj in listVehicles
                                        orderby obj.GetSpeed(SpeedUnit.Kmph) ascending
                                        select obj;
            foreach (var obj in orderBySpeedAscending)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n>>> Print only ground type, sorted by speed descending <<<");
            var orderBySpeedDescending = from obj in listVehicles
                                         orderby obj.GetSpeed(SpeedUnit.Kmph) descending
                                         select obj;
            foreach (var obj in orderBySpeedDescending)
            {
                if (obj.Type == VehicleType.Ground)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}
