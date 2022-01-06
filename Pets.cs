using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InterfaceJson
{
    interface IPetshop
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    class Person : IPetshop
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string StateOfOrigin { get; set; }

        public List<Pets> Pet { get; set; }
    }
    class Pets : IPetshop
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Type { get; set; }
    }
    class PersonMenager
    {
        public void Add(Person person)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.WriteLine(JsonSerializer.Serialize(person, options));
        }
    }
}
