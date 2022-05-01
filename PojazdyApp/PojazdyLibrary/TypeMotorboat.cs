using System;

namespace PojazdyLibrary
{
    public class TypeMotorboat : VehicleWater
    {
        public EngineType Engine { get; set; }
        public TypeMotorboat(EngineType engineType, int displacement) : base()
        {
            Type = "Motorboat";
            Engine = engineType;
            Displacement = displacement;
        }

    }
}
