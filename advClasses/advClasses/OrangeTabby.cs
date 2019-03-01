using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advClasses
{
    class OrangeTabby
    {
        public string species;
        public string name;

        public OrangeTabby()
        {
            species = "Cat";
            name = "";
        }
        public OrangeTabby(string Name)
        {
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
            LayOnLap();
            Console.WriteLine("*takes a nap*");
        }
        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
        public void LayOnLap()
        {
            Console.WriteLine("*cuddles on owner's lap*");
        }
    }
}
