using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop_lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of one side: ");
            String str = Console.ReadLine();
            int lenght=int.Parse(str);
            int area = lenght * lenght;
            Console.Write("Area is {0}", area);
        }
    }
}
