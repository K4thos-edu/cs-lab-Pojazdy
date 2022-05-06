using System;

namespace PojazdyLibrary
{
    public class Plane : VehicleAir
    {
        public Plane(Engine engineType) : base()
        {
            Name = "Plane";
            Engine = UseEngine(engineType);
        }

    }
}
