using System;

namespace PojazdyLibrary
{
    public class EnvironmentGround : IEnvironment
    {
        public EnvironmentType Type => EnvironmentType.Ground;
        public SpeedUnit Unit => SpeedUnit.Kmph;
        public int SpeedMin => 1;
        public int SpeedMax => 350;
    }
}
