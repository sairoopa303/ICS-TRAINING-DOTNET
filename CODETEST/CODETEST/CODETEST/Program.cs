using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODETEST

{
    class IPLCRICKETMATCH
    {
        static void Main(string[] args)
        {
            int Total, Sum = 0, Value; float Average;
            Console.WriteLine("Enter the total count of MATCHES: ");
            Total = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Total; i++)
            {
                Console.WriteLine("ENTER A TEAMSCORE: ");
                Value = Convert.ToInt32(Console.ReadLine());
                Sum += Value;
            }
            Average = (float)Sum / Total;
            Console.WriteLine("Sum: " + Sum + ", Average: " + Average);
        }
    }
}
