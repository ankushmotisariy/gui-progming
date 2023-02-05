using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1b
{
    class Ankush2
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double total;
            Console.WriteLine("Enter first number :");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToDouble(Console.ReadLine());
            total = num2 + num1;
            Console.WriteLine("\nTotal is : " + total);
            Console.ReadLine();

        }
    }
}
