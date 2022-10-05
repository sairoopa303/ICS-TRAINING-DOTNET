using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program2
{
    public static void Main()
    {
        int num;
        Console.Write("\n\n");
        Console.Write("Check whether given a number positive or negative:\n");
        Console.Write("----------------------------------------");
        Console.Write("\n\n");
        Console.Write("Inout an integer : ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0)
            Console.WriteLine("{0} is a positive number.\n", num);
        elses
            Console.Write("{0} is a negative number.\n", num);
        Console.ReadLine();
    }
}
