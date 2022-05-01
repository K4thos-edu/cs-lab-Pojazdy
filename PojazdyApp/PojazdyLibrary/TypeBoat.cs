using System;

namespace PojazdyLibrary
{
    public class TypeBoat : VehicleWater
    {
        public TypeBoat(int displacement) : base()
        {
            Type = "Boat";
            Displacement = displacement;
        }

    }
}
