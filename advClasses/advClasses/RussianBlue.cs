using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advClasses
{
    class RussianBlue
    {
        public string species;
        public string name;

        public RussianBlue()
        {
            species = "Cat";
            name = "";
        }
        public RussianBlue(string Name)
        {
            name = Name;
        }
        public void MakeSound()
        {
            Console.WriteLine("HISSSS");
        }
        public void PrintName()
        {
            Console.WriteLine(name);
        }
        public void BeHappy()
        {
            Console.WriteLine("prrrrrrrr");
            SeeLaser();
        }
        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}
