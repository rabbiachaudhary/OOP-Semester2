using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Lilys age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The privce of washing machine: ");
            double machine_price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The price of Toys: ");
            int toys_price = int.Parse(Console.ReadLine());
            CalculateAmount(age,machine_price, toys_price);
        }
        static void CalculateAmount(int age, double machine_price,int toys_price)
        {
            int amount = 0;
            int total = 0;
            for(int x = 0; x < age; x++)
            {
                if (x % 2 == 0)
                {
                    amount = amount + 10;
                    total += amount;
                }
                if (x % 2 != 0)
                {
                    total += toys_price;
                }
            }
            if (total >= machine_price)
            {
                Console.WriteLine("Yesssssssss");
            }
            else
            {
                Console.WriteLine("noooo");
            }
            
            
        }
    }
}
