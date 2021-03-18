using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safari_Park
{
    public class Hunter : Person
    {
        private string _camera;
        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            this._camera = camera;
        }

        public Hunter()
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}"; // This is over-riding the base class ".ToString"?
        }

        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }
    }
}