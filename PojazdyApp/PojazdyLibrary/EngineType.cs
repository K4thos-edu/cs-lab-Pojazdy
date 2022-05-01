using System;

namespace PojazdyLibrary
{
    public class EngineType
    {
        private readonly int Power;
        private readonly FuelType Fuel;
        public EngineType(int horsePower, FuelType fuelType)
        {
            Power = horsePower;
            Fuel = fuelType;
        }
    }
}
