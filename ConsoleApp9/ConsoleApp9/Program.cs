using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.PrintDescription();
            Animal cat = new Animal("purple","Meow the second","cat");
            Console.ReadKey();
        }
    }
}
