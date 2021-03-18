using System;

namespace Safari_Park
{
    public class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int _age;
        public int Age { get; set; }

        public Person()
        {
            FirstName = "Not";
            LastName = "Known";
        }
        public Person(string fName, string lName, int age = 18)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetAge()
        {
            return $"{FirstName}'s age is {Age}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }
        class Program
        {
            static void Main(string[] args)
            {
                Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 }; 
                a.Ascend(500);
                Console.WriteLine(a.Move(3));
                Console.WriteLine(a);
                a.Descend(200);
                Console.WriteLine(a.Move());
                a.Move();
                Console.WriteLine(a);
            }
        }
    }
}
