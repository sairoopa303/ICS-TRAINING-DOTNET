using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Programassign2
{
    public static void Main(string[] args)
    {
        string s, revs = "";
        Console.WriteLine(" Enter the string: ");
        s = Console.ReadLine();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            revs += s[i].ToString();
        }
        if (revs == s)
        {
            Console.WriteLine("the string is Palindrome", s, revs);
        }
        else
        {
            Console.WriteLine("the string is not Palindrome", s, revs);
        }
        Console.ReadLine();
    }
}


