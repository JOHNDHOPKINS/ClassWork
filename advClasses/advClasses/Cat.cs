using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advClasses
{
    class Cat
    {
        public string species;
        public string name;

        public Cat()
        {
            species = "Cat";
            name = "";
        }
        public Cat(string Name)
        {
            species = "Cat";
            name = Name;
        }
        public void MakeSound()
        {
            Console.WriteLine("meow");
        }
        public void PrintName()
        {
            Console.WriteLine(name);
        }
        public void BeHappy()
        {
            Console.WriteLine("prrrrrrrr");
            SeeLaser();
            MakeSound();
        }
        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}
