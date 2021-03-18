﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Person : IMoveable
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person() { }
        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public virtual string Move()
        {
            return "Walking along";
        }

        public virtual string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}
