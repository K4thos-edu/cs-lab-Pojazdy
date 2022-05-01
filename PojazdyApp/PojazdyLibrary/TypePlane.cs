using System;

namespace PojazdyLibrary
{
    public class TypePlane : VehicleAir
    {
        public EngineType Engine { get; set; }
        public TypePlane(EngineType engineType) : base()
        {
            Type = "Plane";
            Engine = engineType;
        }

    }
}
