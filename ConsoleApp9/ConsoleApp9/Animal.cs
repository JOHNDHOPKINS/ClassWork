using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Animal
    {
        public string species;
        public string name;
        public string color;
        public int age = 0;

        public Animal()
        {
            species = "Dino";
            name = "Bob";
            color = "Blue";
            age = 0;
        }
        public Animal (string Color, string Name,string Species)
        {
            species = Species;
            name = Name;
            color = Color;
        }
        public void MakeSound()
        {
            Console.WriteLine("Grrrrrrrrrrrrrrrrr");
        }
        public  void SetAge(int newAge)
        {
            age = newAge;
        }
        public void PrintDescription()
        {
            Console.WriteLine(name+" is "+age+" years old, "+color+" "+species);
        }
    }
}
