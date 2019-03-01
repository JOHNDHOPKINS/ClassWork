using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects_2_int
{
    class Student
    {
        public int studentID;
        public string name;
        public double contentGrade;
        public double workHabitGrade;
        public double participation;
        public int age;
        public Student()
        {
            studentID = -1;
            name = ("TestStudent");
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
            age = 18;
        }
        public Student(string Name,int ID,int Age)
        {
            age = Age;
            name = Name;
            studentID = ID;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
        }
        public void SetContentGrade(int grade)
        {
            contentGrade = grade;
        }
        public void SetWorkHabitGrade(int grade)
        {
            workHabitGrade = grade;
        }
        public void SetParticipation(int grade)
        {
            participation = grade;
        }
        public double GetGrade()
        {
            return (0.35 * workHabitGrade+0.4*contentGrade+0.25*participation);
        }
        public void PrintGrade()
        {
             Console.WriteLine(0.35 * workHabitGrade + 0.4 * contentGrade + 0.25 * participation);
        }
    }
}
