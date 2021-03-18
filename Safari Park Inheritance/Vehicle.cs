using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safari_Park
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;
        protected int _speed;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (value <= _capacity & value >= 0) { _numPassengers = value; }
                else if (value > _capacity) { _numPassengers = _capacity; }
                else { throw new ArgumentException(); }
            } 
        }

        public int Capacity { get { return _capacity;} }
        public int Position { get; private set; }

        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }

        string ToString()
        {
            return "This is a vehicle";
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