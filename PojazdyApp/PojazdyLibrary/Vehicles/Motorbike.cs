using System;

namespace PojazdyLibrary
{
    public class Motorbike : VehicleGround
    {
        public Motorbike(Engine engineType) : base()
        {
            Name = "Motorbike";
            Engine = UseEngine(engineType);
            Wheels = 2;
        }

    }
}
