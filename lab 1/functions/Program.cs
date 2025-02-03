using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter number 1: ");
            string str= Console.ReadLine();
            n1= int.Parse(str);
            Console.WriteLine("Enter number 2: ");
            string str1 = Console.ReadLine();
            n2 = int.Parse(str1);
            Console.WriteLine("sum of twwo numbers {0} and {1} is {2}", n1, n2, sum(n1, n2)); ;
        }
        static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
