using System;

namespace PojazdyLibrary
{
    public class Motorboat : VehicleWater
    {
        public Motorboat(Engine engineType, int displacement) : base()
        {
            Name = "Motorboat";
            Engine = UseEngine(engineType);
            Displacement = displacement;
        }

    }
}
