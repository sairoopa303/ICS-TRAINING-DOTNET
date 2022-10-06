using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ASSIGNMENT_4_2_
{
    public static void Main()
    {
        string str = "oops programing";
        char ch = 'o';

        int freq = str.Count(f => (f == ch));
        Console.WriteLine(freq);
        Console.ReadLine();
    }
}
