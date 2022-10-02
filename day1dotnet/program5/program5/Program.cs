 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class program5
{
    public static void Main(string[] args)
    {
        double fahrenheit;
        double celsius = 6;
        Console.WriteLine("Celsius: " + celsius);
        fahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine("Fahrenheit: " + fahrenheit);
        Console.ReadLine();
    }
}
