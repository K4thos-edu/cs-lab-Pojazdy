using System;

namespace PojazdyLibrary
{
    public enum SpeedUnit
    {
        mps,
        kmph,
        knots
    }
    public enum FuelType
    {
        gas,
        oil,
        lpg,
        electric
    }
    public enum MotorState
    {
        on,
        off
    }
    public enum MovementEnvironment
    {
        ground,
        air,
        water
    }
    public enum VehicleState
    {
        moving,
        stationary
    }
}
