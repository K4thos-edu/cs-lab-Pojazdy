using System;

namespace PojazdyLibrary
{
    public class Amphibian : VehicleMultipurpose
    {
        public Amphibian(Engine engineType)
        {
            Name = "Amphibian";
            Engine = UseEngine(engineType);
        }

    }
}
