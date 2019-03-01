using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advClasses
{
    public class Dog
    {
        public string species;
        public string name;
        public bool dockedTail;

        public Dog()
        {
            species = "Dog";
            name = "";
            dockedTail = false;
        }
        public Dog(string Name,bool DockedTail)
        {
            name = Name;
            dockedTail = DockedTail;
        }
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        public void PrintName()
        {
            Console.WriteLine(name);
        }
        public void PlayFetch()
        {
            Console.WriteLine("*chases ball 5 times then quits*");
        }
        public bool GetDockedTail()
        {
            return (dockedTail);
        }
    }
}
