using System;

namespace PojazdyLibrary
{
    public enum VehicleType
    {
        Air,
        Ground,
        Water,
        Multipurpose
    }
    public enum VehicleState
    {
        Moving,
        Stationary
    }
    public enum EnvironmentType
    {
        Air,
        Ground,
        Water
    }
    public enum SpeedUnit
    {
        Mps,
        Kmph,
        Knots
    }
    public enum FuelType
    {
        Gas,
        Oil,
        Lpg,
        Electric
    }
    public enum EngineState
    {
        On,
        Off
    }
}
