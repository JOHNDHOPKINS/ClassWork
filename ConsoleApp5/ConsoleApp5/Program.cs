using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class savingsCalculator
    {
        static void Main(string[] args)
        {
            double startingBalance = 0;
            Console.WriteLine("Starting Balance:");
            try
            {
                startingBalance = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (startingBalance < 0)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double yearlyContribution = 0;
            Console.WriteLine("Enter Yearly Contribution:  ");
            try
            {
                yearlyContribution = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (yearlyContribution < 0)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double averageReturn = 0;
            Console.WriteLine("Enter Average Return On Investment as %:  ");
            try
            {
                averageReturn = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (averageReturn<0)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double numberOfYears = 0;
            Console.WriteLine("Enter Number of years:  ");
            try
            {
                numberOfYears = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (numberOfYears < 0)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Year 0: " + startingBalance);
            averageReturn = averageReturn / 100;
            int i = 1;
            double yearTotal = startingBalance;
            while (i < numberOfYears+1)
            {
                yearTotal = ((yearTotal) + (yearlyContribution))+(yearTotal*averageReturn);
                Console.WriteLine("Year "+i+": "+yearTotal);
                i++;
            }
            Console.ReadLine();
        }
    }
}
