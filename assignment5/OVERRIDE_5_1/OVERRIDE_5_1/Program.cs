using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ASSIGNMENT_5_1_
{
    abstract class Student
    {
        public string Name; public int StudentId; public float grade;

        public abstract bool IsPassed(float grade);

    }

    class UndergGrad : Student
    {


        public override bool IsPassed(float grade)
        {
            if (grade > 60.0f)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }
        }
    }
    class Grad : Student
    {
        public override bool IsPassed(float grade)
        {
            if (grade > 60.0f)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }

        }
    }
    class STUDENT
    {
        static void Main(string[] args)
        {
            Student student = new UndergGrad(); student.Name = "SAI"; student.StudentId = 1030;
            Console.WriteLine("enter the grade for undergrad:");
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);
            student = new Grad(); student.Name = "ROOPA"; student.StudentId = 057;
            Console.WriteLine("Enter the grade for grad");
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);
            Console.ReadLine();



        }
    }
}
