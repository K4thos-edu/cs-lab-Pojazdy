using System;

namespace PojazdyLibrary
{
    public class TypeCar : VehicleGround
    {
        public EngineType Engine { get; set; }
        public TypeCar(EngineType engineType) : base()
        {
            Type = "Car";
            Engine = engineType;
            Wheels = 4;
        }

    }
}
