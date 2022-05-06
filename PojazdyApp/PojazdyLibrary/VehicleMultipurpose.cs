using System;

namespace PojazdyLibrary
{
    public abstract class VehicleMultipurpose : Vehicle
    {
        protected int Wheels;
        protected int Displacement;

        protected VehicleMultipurpose() : base()
        {
            Type = VehicleType.Multipurpose;
            EnvironmentCurrent = IEnvironment.Environments.EnvironmentGround;
            State = VehicleState.Stationary;
        }

        public void VehicleWaterToGround()
        {
            if (EnvironmentCurrent.Type != EnvironmentType.Water)
            {
                Console.WriteLine($"The {Name} can't change to ground environment. This vehicle is not in a water.");
                return;
            }
            VehicleChangeEnviorment(EnvironmentType.Ground);
        }

        public void VehicleGroundToWater()
        {
            if (EnvironmentCurrent.Type != EnvironmentType.Ground)
            {
                Console.WriteLine($"The {Name} can't change to water environment. This vehicle is not on the ground.");
                return;
            }
            VehicleChangeEnviorment(EnvironmentType.Water);
        }
    }
}
