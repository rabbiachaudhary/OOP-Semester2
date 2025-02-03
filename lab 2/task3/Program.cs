using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Balance;
            Console.WriteLine("Enter your current balance: ");
            Balance = double.Parse(Console.ReadLine());
            ATM obj = new ATM(Balance);
            while (true)
            {

                Console.WriteLine("Select an opion..");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Transaction History");
                Console.WriteLine("enter option...");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    Console.WriteLine("Enter the amount u want to deposit: ");
                    double a = double.Parse(Console.ReadLine());
                    obj.Deposit(a);
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Enter the amount u wnat to withdraw: ");
                    double a = double.Parse(Console.ReadLine());
                    obj.Withdraw(a);
                }
                else if (opt == 3)
                {
                    obj.Check_Balance();
                }
                else if (opt == 4)
                {
                    obj.History();
                }
            }
        }
    }
}
