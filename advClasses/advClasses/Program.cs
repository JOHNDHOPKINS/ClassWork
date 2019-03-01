using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Garfield garfield = new Garfield();
            garfield.PrintName();
            garfield.BeHappy();
            garfield.LayOnLap();
            garfield.SeeLaser();
            garfield.MakeSound();
            RussianBlue russianBlue = new RussianBlue("Jeff");
            russianBlue.PrintName();
            russianBlue.SeeLaser();
            russianBlue.BeHappy();
            russianBlue.MakeSound();
            OrangeTabby orangeTabby = new OrangeTabby("Bob");
            orangeTabby.PrintName();
            orangeTabby.SeeLaser();
            orangeTabby.MakeSound();
            orangeTabby.LayOnLap();
            Cat cat = new Cat("Theotherone");
            cat.PrintName();
            cat.SeeLaser();
            cat.MakeSound();
            Dog dog = new Dog("Carrot",true);
            dog.PrintName();
            dog.GetDockedTail();
            dog.MakeSound();
            dog.PlayFetch();
            Animal fish = new Animal("Fish","Nemo");
            fish.MakeSound();
            Console.ReadLine();
        }
    }
}
