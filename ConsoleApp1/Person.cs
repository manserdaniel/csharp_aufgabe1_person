using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        string name, home, job;

        public int Age { get; set; }

        public Person(string name, string home, int age)
        {
            this.Name = name;
            this.Home = home;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Home { get => home; set => home = value; }
        public string Job { get => job; set => job = value; }
    }
}
