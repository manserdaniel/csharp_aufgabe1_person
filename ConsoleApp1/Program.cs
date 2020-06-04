using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFileContent = System.IO.File.ReadAllLines("C:\\Users\\daniel\\Source\\Repos\\ConsoleApp1\\ConsoleApp1\\persons.txt");
            List<Person> persons = new List<Person>();
           
            foreach (string person in myFileContent)
            {
                string[] personSplitted = person.Split(";");
                int.TryParse(personSplitted[2], out var age);
                persons.Add(new Person(personSplitted[0], personSplitted[1], age));

            }

            persons.Find(p => p.Name == "Hans").Job = "Coder";
            persons.Find(p => p.Name == "Helga").Job = "Coder";
            persons.Find(p => p.Name == "Fritz").Job = "Officer";
            persons.Find(p => p.Name == "Frida").Job = "Officer";

            string[] myFileContentOutput = new string[persons.Count];

            for(int i = 0; i < persons.Count; i++)
            {
                myFileContentOutput[i] = persons[i].Name + ";" + persons[i].Age + ";" + persons[i].Home + ";" + persons[i].Job;
            }

            System.IO.File.WriteAllLines("C:\\Users\\daniel\\Source\\Repos\\ConsoleApp1\\ConsoleApp1\\output.txt", myFileContentOutput);
        }
    }
}