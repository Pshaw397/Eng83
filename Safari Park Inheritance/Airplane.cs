using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park 
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane(int capacity)
        {
            _capacity = capacity;
        }

        public Airplane(int capacity, int speed, string airline) : base (capacity, speed)
        {
            _airline = airline;
            _capacity = capacity;
            _speed = speed;
        }

        public void Ascend(int distance)
        {
            _altitude += distance;
        }

        public void Descend (int distance)
        {
            _altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {_altitude} metres";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {_altitude} metres";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {Capacity} passengers: {NumPassengers} speed: {_speed} position: {Position} altitude: {_altitude}";
        }
    }
}
