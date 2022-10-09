using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASSIGNMENT_5_4_
{
    class DAYSCHOLOR
    {
        static void Main(string[] args)
        {
            IStudent student = new DayScholor();

            student.Name = "SAI"; student.StudentId = 1030;
            student.ShowDetails();
            IStudent resident = new Resident();
            resident.Name = "ROOPA"; resident.StudentId = 057;
            resident.ShowDetails();
            Console.ReadLine();
        }
    }
    interface IStudent
    {
        int StudentId
        {
            get; set;
        }
        string Name
        {
            get; set;
        }
        void ShowDetails();
    }
    class DayScholor : IStudent
    {
        string name; int id;
        public int StudentId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        void IStudent.ShowDetails()
        {
            Console.WriteLine("DayScholor");
            Console.WriteLine(" Student Id: {0}", id);
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine();
        }
    }
    class Resident : IStudent
    {
        string name; int id;
        public int StudentId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        void IStudent.ShowDetails()
        {
            Console.WriteLine("Resident");
            Console.WriteLine(" Student Id: {0}", id);
            Console.WriteLine("Student Name: {0}", name);
        }
    }
}
