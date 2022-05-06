using System;

namespace PojazdyLibrary
{
    public class Car : VehicleGround
    {
        public Car(Engine engineType) : base()
        {
            Name = "Car";
            Engine = UseEngine(engineType);
            Wheels = 4;
        }

    }
}
