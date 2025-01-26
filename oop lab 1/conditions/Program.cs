using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            string str = Console.ReadLine();
            int marks=int.Parse(str);
            if (marks > 50)
            {
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("failed");
            }
            Console.Read();
        }
    }
}
