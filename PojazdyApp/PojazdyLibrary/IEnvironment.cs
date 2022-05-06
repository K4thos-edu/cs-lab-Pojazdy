using System;

namespace PojazdyLibrary
{
    public interface IEnvironment
    {
        public EnvironmentType Type { get; }
        public SpeedUnit Unit { get; }
        public int SpeedMin { get; }
        public int SpeedMax { get; }

        public static class Environments
        {
            public static readonly EnvironmentAir EnvironmentAir = new EnvironmentAir();
            public static readonly EnvironmentGround EnvironmentGround = new EnvironmentGround();
            public static readonly EnvironmentWater EnvironmentWater = new EnvironmentWater();
        }
    }
}
