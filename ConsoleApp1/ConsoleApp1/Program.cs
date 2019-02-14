using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a addition program
            Console.Write("enter a number:  ");
            string whatTheUserTyped = Console.ReadLine();
            int aNumber = Convert.ToInt32(whatTheUserTyped);//changes a string into a int
            Console.Write("enter a number:  ");
            string otherInput = Console.ReadLine();
            int Number = Convert.ToInt32(otherInput);
            int a = Number + aNumber;//adds them then puts the outcome in "a"
            Console.WriteLine (a);
            Console.ReadKey();//this makes it so the program dosnt close untill you press a key
        }
    }
}
