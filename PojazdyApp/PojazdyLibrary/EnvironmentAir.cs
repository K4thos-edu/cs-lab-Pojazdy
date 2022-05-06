using System;

namespace PojazdyLibrary
{
    public class EnvironmentAir : IEnvironment
    {
        public EnvironmentType Type => EnvironmentType.Air;
        public SpeedUnit Unit => SpeedUnit.Mps;
        public int SpeedMin => 20;
        public int SpeedMax => 200;
    }
}
