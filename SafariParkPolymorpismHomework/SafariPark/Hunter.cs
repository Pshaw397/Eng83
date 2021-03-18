using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }
        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            string output = "";
            if (Shooter is Camera)
            {
                output = $"{GetFullName()}: Shooting a {Shooter.ToString()} - {Shooter.Shoot()}";
            }
            else
            {
                output = $"{GetFullName()}: {Shooter.Shoot()} Shooting a {Shooter.ToString()}";
            }
            return output;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
