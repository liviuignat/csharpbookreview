using System;
using static System.Console;
using System.Collections.Generic;
namespace Packt.LearningCS
{
    public partial class Person : IComparable<Person>
    {
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        
        public string Name;
        public string FirstName;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        public string Origin // C# 1.0 - 5.0 syntax
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        public string Greeting => $"{Name} says 'Hello!'"; // C# 6.0 syntax
        public int Age => (int)(DateTime.Today.Subtract(DateOfBirth).TotalDays / 365.25);
        
        public Person()
        {
            Name = "Unknown"; // set a default name
            Instantiated = DateTime.Now;
        }

        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public string SayHello()
        {
            return $"{FirstName} says 'Hello!'";
        }
        public string SayHelloTo(string name)
        {
            return $"{FirstName} says 'Hello {name}!'";
        }
        public void OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            WriteLine($"command is {command}, number is {number}, active is {active}");
        }

        public Person Procreate(Person partner)
        {
            return new Person("Baby");
        }

        public static Person operator *(Person p1, Person p2) => new Person("Baby");

        public int MethodIWantToCall(string input)
        {
            return input.Length;
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }

    }
}
