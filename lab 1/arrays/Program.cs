using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number at index: {0}", i);
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            int lg = -100;
            for(int i = 0;i < 3; i++)
            {
                if (arr[i] > lg)
                {
                    lg = arr[i];
                }
            }
            Console.WriteLine("The largest number is {0}", lg);
            Console.Read();
        }

    }
}
