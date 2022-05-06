using System;

namespace PojazdyLibrary
{
    public abstract class VehicleAir : Vehicle
    {
        protected VehicleAir() : base()
        {
            Type = VehicleType.Air;
            EnvironmentCurrent = IEnvironment.Environments.EnvironmentGround;
            State = VehicleState.Moving;
        }

        public void VehicleLand()
        {
            if (EnvironmentCurrent.Type != EnvironmentType.Air)
            {
                Console.WriteLine($"The {Name} can't land. This vehicle is not in the air.");
                return;
            }
            if (Speed != UnitConverter(IEnvironment.Environments.EnvironmentAir.SpeedMin, IEnvironment.Environments.EnvironmentGround.Unit, EnvironmentCurrent.Unit))
            {
                Console.WriteLine($"The {Name} can't land. Air vehicle can change from air to ground enviorment only if its speed equals {IEnvironment.Environments.EnvironmentAir.SpeedMin} {IEnvironment.Environments.EnvironmentGround.Unit}.");
                return;
            }
            VehicleChangeEnviorment(EnvironmentType.Ground);
            Console.WriteLine($"The {Name} landed.");
        }

        public void VehicleTakeOff()
        {
            if (EnvironmentCurrent.Type != EnvironmentType.Ground)
            {
                Console.WriteLine($"The {Name} can't take off. This vehicle is not on the ground.");
                return;
            }
            if (Speed < UnitConverter(IEnvironment.Environments.EnvironmentAir.SpeedMin, IEnvironment.Environments.EnvironmentAir.Unit, EnvironmentCurrent.Unit))
            {
                Console.WriteLine($"The {Name} can't take off. Air vehicle can change from ground to air enviorment only if its speed is at least {IEnvironment.Environments.EnvironmentAir.SpeedMin} {IEnvironment.Environments.EnvironmentGround.Unit}.");
                return;
            }
            VehicleChangeEnviorment(EnvironmentType.Air);
            Console.WriteLine($"The {Name} took off.");
        }

        public override void VehicleStop()
        {
            if (EnvironmentCurrent.Type == EnvironmentType.Air)
            {
                Console.WriteLine($"The {Name} can't be stopped in air environment.");
                return;
            }
            base.VehicleStop();
        }
    }
}
