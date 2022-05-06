using System;

namespace PojazdyLibrary
{
    public abstract class VehicleWater : Vehicle
    {
        protected int Displacement;

        protected VehicleWater() : base()
        {
            Type = VehicleType.Water;
            EnvironmentCurrent = IEnvironment.Environments.EnvironmentWater;
            State = VehicleState.Stationary;
        }

        public override Engine UseEngine(Engine engineType)
        {
            if (engineType.Fuel != FuelType.Oil)
            {
                Console.WriteLine("Water vehicle with engine always uses oil fuel.");
                engineType = new Engine(engineType.Power, FuelType.Oil);
            }
            return engineType;
        }
    }
}
