﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class ASSIGNMENT2_3_D
{
    public static void Main()
    {
        string str1 = "sairoopa";
        string str2 = "sairoopa";
        char[] ch1 = str1.ToLower().ToCharArray();
        char[] ch2 = str2.ToLower().ToCharArray();
        Array.Sort(ch1);
        Array.Sort(ch2);
        string val1 = new string(ch1);
        string val2 = new string(ch2);

        if (val1 == val2)
        {
            Console.WriteLine("Both the strings are same");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Both the strings are not same");
            Console.ReadLine();
        }
    }
}
