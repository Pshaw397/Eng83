using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safari_Park
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (value <= _capacity & value >= 0) { _numPassengers = value; } else { _numPassengers = _capacity; } } 
        }

        public int Capacity { get { return _capacity;} }
        public int Position { get; private set; }

        public string Move()
        {
            Position = _speed * 1;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position = times * _speed;
            return $"Moving along {times.ToString()} times";
        }

        public  Vehicle()
        {
            _speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _speed = speed;
            _capacity = capacity;
        }
    }
}