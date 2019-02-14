using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 0;
            while (i < 500)
            {
                Console.WriteLine("Testing Loops");
                i++;
            }
            i = 1;
            while (i < 101)
            {
                Console.WriteLine("current loop iteration: "+i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
