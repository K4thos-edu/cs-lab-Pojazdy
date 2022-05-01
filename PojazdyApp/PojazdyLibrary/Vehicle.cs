using System;

namespace PojazdyLibrary
{
    public abstract class Vehicle
    {
        protected string Type = "Unknown";

        protected MovementEnvironment Environment;
        protected VehicleState State;
        protected SpeedUnit Unit;

        public virtual double SpeedMin { get; set; }
        public virtual double SpeedMax { get; set; }

        protected double Speed = 0;

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
                case SpeedUnit.kmph:
                    if (toUnit == SpeedUnit.mps)
                    {
                        output = speed * 1000 / 3600;
                    }
                    else // knots
                    {
                        output = speed / 1.852;
                    }
                        
                    break;
                case SpeedUnit.mps:
                    if (toUnit == SpeedUnit.kmph)
                    {
                        output = speed / 1000 * 3600;
                    }
                    else // knots
                    {
                        output = speed / 1852 * 3600;
                    }
                    break;
                case SpeedUnit.knots:
                    if (toUnit == SpeedUnit.kmph)
                    {
                        output = speed * 1.852;
                    }
                    else // mps
                    {
                        output = speed * 1852 / 3600;
                    }
                    break;
            }
            return Math.Round(output, precision);
        }

    }
}
