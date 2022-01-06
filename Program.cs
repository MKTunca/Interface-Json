using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InterfaceJson
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonMenager menager = new PersonMenager();
            var pets = new List<Pets>
            {
               new Pets { Type = "Cat", Name = "Ozi", Age = 5 },
               new Pets { Type = "Dog", Name = "Cash", Age = 10}
            };
            var person = new Person
            {
                Name = "Mustafa",
                Age = 24,
                StateOfOrigin = "Turkey",
                Pet = pets
            };
            menager.Add(person);
            Console.ReadLine();
        }
    }
}
