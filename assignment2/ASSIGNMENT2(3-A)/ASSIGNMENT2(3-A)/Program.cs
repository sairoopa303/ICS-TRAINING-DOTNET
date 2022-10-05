using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ASSIGNMENT2_3_1
{
    public static void Main(string[] args)
    {
        string str;
        int l = 0;

        Console.Write("\n\n find length of a string \n");

        Console.Write("enter input string: ");
        str = Console.ReadLine();
        foreach (char chr in str)
        {
            l += 1;
        }
        Console.Write("length of string is {0}\n\n", l);
        Console.ReadLine();
    }
}
