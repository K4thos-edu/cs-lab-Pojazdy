using System;

namespace PojazdyLibrary
{
    public abstract class Vehicle
    {
        protected string Name { get; set; }
        public VehicleType Type { get; protected set; }
        public IEnvironment EnvironmentCurrent { get; protected set; }
        protected Engine Engine { get; set; }
        protected VehicleState State { get; set; }

        protected double Speed { get; set; }

        protected Vehicle()
        {

        }

        public static double UnitConverter(double speed, SpeedUnit fromUnit, SpeedUnit toUnit, int precision = 2)
        {
            double output = 0;
            if (fromUnit == toUnit)
            {
                return speed;
            }
            switch (fromUnit)
            {
                case SpeedUnit.Kmph:
                    if (toUnit == SpeedUnit.Mps)
                    {
                        output = speed * 1000 / 3600;
                    }
                    else // Knots
                    {
                        output = speed / 1.852;
                    }

                    break;
                case SpeedUnit.Mps:
                    if (toUnit == SpeedUnit.Kmph)
                    {
                        output = speed / 1000 * 3600;
                    }
                    else // Knots
                    {
                        output = speed / 1852 * 3600;
                    }
                    break;
                case SpeedUnit.Knots:
                    if (toUnit == SpeedUnit.Kmph)
                    {
                        output = speed * 1.852;
                    }
                    else // Mps
                    {
                        output = speed * 1852 / 3600;
                    }
                    break;
            }
            return Math.Round(output, precision);
        }

        public void VehicleStart()
        {
            if (Engine != null && Engine.State == EngineState.On)
            {
                Engine.State = EngineState.On;
            }
            Speed = EnvironmentCurrent.SpeedMin;
            State = VehicleState.Moving;
            Console.WriteLine($"The {Name} started moving at {Speed} {EnvironmentCurrent.Unit}.");
        }

        public virtual void VehicleStop()
        {
            if (Engine != null && Engine.State == EngineState.On)
            {
                Engine.State = EngineState.Off;
            }
            Speed = 0;
            State = VehicleState.Stationary;
            Console.WriteLine($"The {Name} stopped moving.");
        }

        public void VehicleAccelerate(double add)
        {
            if (State == VehicleState.Stationary)
            {
                Console.WriteLine($"The {Name} is not moving. Can't accelerate.");
                return;
            }
            Speed = Math.Min(Speed + add, EnvironmentCurrent.SpeedMax);
            Console.WriteLine($"The {Name} accelerated to {Speed} {EnvironmentCurrent.Unit}.");
        }

        public void VehicleDecelerate(double sub)
        {
            if (State == VehicleState.Stationary)
            {
                Console.WriteLine($"The {Name} is not moving. Can't decelerate.");
                return;
            }
            Speed = Math.Max(Speed - sub, EnvironmentCurrent.SpeedMin);
            Console.WriteLine($"The {Name} decelerated to {Speed} {EnvironmentCurrent.Unit}.");
        }

        public void VehicleChangeEnviorment(EnvironmentType toEnvironment)
        {
            Console.WriteLine($"The {Name} is switching from {EnvironmentCurrent.Type} to {toEnvironment} environment.");
            switch (toEnvironment)
            {
                case EnvironmentType.Air:
                    Speed = UnitConverter(Speed, EnvironmentCurrent.Unit, IEnvironment.Environments.EnvironmentAir.Unit);
                    EnvironmentCurrent = IEnvironment.Environments.EnvironmentAir;
                    break;
                case EnvironmentType.Ground:
                    Speed = UnitConverter(Speed, EnvironmentCurrent.Unit, IEnvironment.Environments.EnvironmentGround.Unit);
                    EnvironmentCurrent = IEnvironment.Environments.EnvironmentGround;
                    break;
                case EnvironmentType.Water:
                    Speed = UnitConverter(Speed, EnvironmentCurrent.Unit, IEnvironment.Environments.EnvironmentWater.Unit);
                    EnvironmentCurrent = IEnvironment.Environments.EnvironmentWater;
                    break;
            }
        }

        public virtual Engine UseEngine(Engine engineType)
        {
            return engineType;
        }

        public double GetSpeed(SpeedUnit speedUnit)
        {
            return UnitConverter(Speed, EnvironmentCurrent.Unit, speedUnit);
        }
    }
}
