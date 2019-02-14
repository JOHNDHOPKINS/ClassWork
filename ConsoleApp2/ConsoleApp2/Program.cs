using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int e=0;e<3;e++)
            {
                int a;
                Console.Write("Guess the number:  ");
                string w = Console.ReadLine();
                a = Convert.ToInt32(w);
                if (a == 7)
                {
                    Console.WriteLine("Congrats!");
                    break;
                }
                else if(a!=7 && e!=2)
                {
                    Console.Write("Fail!");
                }
                else
                {
                    Console.Write("Too bad!!");
                }
            }
            Console.ReadKey();
        }
    }
}
