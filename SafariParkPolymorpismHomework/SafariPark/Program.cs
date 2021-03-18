using System;
using System.Collections.Generic;

namespace ClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera Nikon = new Camera("Nikon");
            List<IShootable> weaponList = new List<IShootable>
            {
                new WaterPistol("Super Soaker"),
                new LaserGun("Lazer Rifle 9000"),
                new Hunter("Harry", "Bradson", Nikon),
                new Camera("Kodak")
            };

            foreach (var weapon in weaponList)
            {
                //Console.WriteLine(weapon.Shoot());
            }

            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());

        }
    }
}
