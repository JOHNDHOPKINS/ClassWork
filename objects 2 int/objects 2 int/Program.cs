using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects_2_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.PrintGrade();
            Student student2 = new Student("Bob", 12345, 16);
            student2.SetParticipation(99);
            student2.SetContentGrade(85);
            student2.SetWorkHabitGrade(99);
            student2.PrintGrade();
            Console.ReadKey();
        }
    }
}
