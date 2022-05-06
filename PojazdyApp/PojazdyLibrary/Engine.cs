using System;

namespace PojazdyLibrary
{
    public class Engine
    {
        public readonly int Power;
        public readonly FuelType Fuel;

        public EngineState State { get; set; }

        public Engine(int horsePower, FuelType fuelType)
        {
            Power = horsePower;
            Fuel = fuelType;
            State = EngineState.Off;
        }
    }
}
