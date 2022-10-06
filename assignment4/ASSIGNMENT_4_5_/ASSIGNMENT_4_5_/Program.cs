using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ASSIGNMENT_4_5_
{
    class Scholorship
    {
        int TotalMarks; float Fees; float ScholorshipAmount;

        static void Main(string[] args)
        {
            Scholorship s = new Scholorship();
            Console.WriteLine("Enter Total Marks");
            s.TotalMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Fees amount");
            s.Fees = Convert.ToSingle(Console.ReadLine());
            s.ScholorshipAmount = s.Merit(s.TotalMarks, s.Fees);
            Console.WriteLine("Scholorship Amount is " + s.ScholorshipAmount);
            Console.Read();

        }
        public float Merit(int TotalMarks, float Fees)
        {
            if (TotalMarks >= 80 && TotalMarks <= 100)
            {
                return (40.0f / 100) * Fees;
            }
            else if (TotalMarks > 60 && TotalMarks <= 70)
            {
                return (60.0f / 100) * Fees;
            }
            else if (TotalMarks > 100)
            {
                return (50.0f / 100) * Fees;
            }
            return 0;
        }

    }
}
