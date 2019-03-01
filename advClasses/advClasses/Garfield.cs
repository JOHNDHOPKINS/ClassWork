using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advClasses
{
    class Garfield
    {
        public string species;
        public string name;

        public Garfield()
        {
            species = "Cat";
            name = "Garfield";
        }
        public void MakeSound()
        {
            Console.WriteLine("mmm,   lasagna");
        }
        public void PrintName()
        {
            Console.WriteLine(name);
        }
        public void BeHappy()
        {
            Console.WriteLine("prrrrrrrr");
            LayOnLap();
            Console.WriteLine("*takes a nap*");
        }
        public void SeeLaser()
        {
            BeHappy();
        }
        public void LayOnLap()
        {
            Console.WriteLine("*cuddles on owner's lap*");
        }
    }
}
