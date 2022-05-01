using System;

namespace PojazdyLibrary
{
    public abstract class VehicleAir : Vehicle
    {
        protected VehicleAir() : base()
        {
            Environment = MovementEnvironment.air;
            State = VehicleState.moving;
            Unit = SpeedUnit.mps;
            SpeedMin = 20;
            SpeedMax = 200;
        }

    }
}
