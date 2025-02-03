using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Enter first number: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            n2 = double.Parse(Console.ReadLine());
            Calculator cal = new Calculator(n1, n2);
            Console.WriteLine("Sum: " + cal.Add());
            Console.WriteLine("difference: " + cal.Substract());
            Console.WriteLine("Product: " + cal.Multiply());
            Console.WriteLine("Divison: " + cal.Divide());
        }
    }
}
