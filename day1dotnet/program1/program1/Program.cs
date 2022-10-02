using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program1
{
    public static void Main()
    {
        int int1, int2;
        Console.Write("\n\n");
        Console.Write("Check whether two integers are eual or not:\n");
        Console.Write("----------------------------------------");
        Console.Write("\n\n");
        Console.Write("Inout 1st number: ");
        int1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Inout 2nd number: ");
        int2 = Convert.ToInt32(Console.ReadLine());
        if (int1 == int2)
            Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
        else
            Console.Write("{0} and {1} are not equal.\n", int1, int2);
        Console.ReadLine();
    }
}
