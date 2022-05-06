using System;

namespace PojazdyLibrary
{
    public abstract class VehicleGround : Vehicle
    {
        protected int Wheels;

        protected VehicleGround() : base()
        {
            Type = VehicleType.Ground;
            EnvironmentCurrent = IEnvironment.Environments.EnvironmentGround;
            State = VehicleState.Stationary;
        }

    }
}
