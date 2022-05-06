using System;

namespace PojazdyLibrary
{
    public class EnvironmentWater : IEnvironment
    {
        public EnvironmentType Type => EnvironmentType.Water;
        public SpeedUnit Unit => SpeedUnit.Knots;
        public int SpeedMin => 1;
        public int SpeedMax => 40;
    }
}
