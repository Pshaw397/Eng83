using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return _brand;
        }

        public string ToSring()
        {
            return base.ToString();
        }
    }
}
