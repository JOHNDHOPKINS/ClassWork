using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            double input1=0;
            try
            {
                input1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Input 1 was not a number.");
                Environment.Exit(0);
            }
            Console.WriteLine("enter a number:");
            double input2=0;
            try
            {
                input2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Input 2 was not a number.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("enter a number:");
            double input3=0;
            try
            {
                input3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Input 3 was not a number.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("enter a number");
            double input4=0;
            try
            {
                input4 = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Input 4 was not a number.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            double output = input1 + input2 + input3 + input4;
            Console.WriteLine("Total: "+output);
            Console.ReadKey();
            }
    }
}
