using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program3
{
    public static void Main()
    {
        int A, B;
        char operation;
        Console.Write("Inout first number: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Inout operation: ");
        operation = Convert.ToChar(Console.ReadLine());
        Console.Write("Inout second number: ");
        B = Convert.ToInt32(Console.ReadLine());
        if (operation == '+')
            Console.WriteLine("{0} + {1} = {2}", A, B, A + B);
        else
            Console.Write("Wrong Character");
        Console.ReadLine();
    }
}
