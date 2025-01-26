using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum=0;
            string str;
            do
            {
                Console.WriteLine("Entern: ");
                str = Console.ReadLine();
                n = int.Parse(str);
                sum += n;
            }
            while (n != -1);
            sum = sum + 1; //to cancel effetct of -1 on sum
            Console.WriteLine(sum);
        }
    }
}
