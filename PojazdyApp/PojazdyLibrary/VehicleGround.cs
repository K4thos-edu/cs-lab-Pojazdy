using System;

namespace PojazdyLibrary
{
    public abstract class VehicleGround : Vehicle
    {
        protected int Wheels;

        protected VehicleGround() : base()
        {
            Environment = MovementEnvironment.ground;
            State = VehicleState.stationary;
            Unit = SpeedUnit.kmph;
            SpeedMin = 1;
            SpeedMax = 350;
        }

    }
}
