using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_5_3
{
    public class CALCULATECONCESSION
    {
        public static void  Main CALCULATECONCENSSION(int age)
        {
            int totalfare = 1000; float ConcessionAmount; float CalculatedAmount;
            if (age <= 10)
            {  Console.WriteLine("Little Champs-Free Ticket");
            }
             else if (age > 50)
            {
                ConcessionAmount = Convert.ToInt32(0.3f * totalfare);
                CalculatedAmount =(ConcessionAmount-totalfare);
                Console.WriteLine("Senior Citizen: " + CalculatedAmount);
            }
            else
            { Console.WriteLine("Ticket Booked: " + totalfare);
            }
        }
    }
}
