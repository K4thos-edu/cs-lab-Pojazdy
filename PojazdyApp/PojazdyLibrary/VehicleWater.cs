using System;

namespace PojazdyLibrary
{
    public abstract class VehicleWater : Vehicle
    {
        protected int Displacement;

        protected VehicleWater() : base()
        {
            Environment = MovementEnvironment.water;
            State = VehicleState.stationary;
            Unit = SpeedUnit.knots;
            SpeedMin = 1;
            SpeedMax = 40;
        }

    }
}
