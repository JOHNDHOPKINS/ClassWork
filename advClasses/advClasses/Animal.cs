using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advClasses
{
    public class Animal
    {
        public string species;
        public string name;
        
        public Animal()
        {
            species = "";
            name = "";
        }
        public void PrintName()
        {
            Console.WriteLine(name);
        }
        public Animal(string Species, string Name)
        {
            species = Species;
            name = Name;
        }
        public void MakeSound()
        {
            Console.WriteLine("Grrrrrrrrrrrrrrrrr");
        }
    }
}
