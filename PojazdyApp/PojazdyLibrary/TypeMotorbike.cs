using System;

namespace PojazdyLibrary
{
    public class TypeMotorbike : VehicleGround
    {
        public EngineType Engine { get; set; }
        public TypeMotorbike(EngineType engineType) : base()
        {
            Type = "Motorbike";
            Engine = engineType;
            Wheels = 2;
        }

    }
}
