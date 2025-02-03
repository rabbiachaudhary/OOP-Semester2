using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class ATM
    {
        public double Balance;
        List<string> transaction = new List<string>();
        public ATM(double b)
        {
            Balance = b;
        }
        public void Deposit(double a)
        {
            Balance += a;
            Console.WriteLine("deposited successfully");
            transaction.Add("Deposited: " + a);
        }
        public void Withdraw(double a)
        {
            Balance -= a;
            Console.WriteLine("Withdrawn successfully");
            transaction.Add("Withdrawn: " + a);
        }
        public void Check_Balance()
        {
            Console.WriteLine("the current balance is "+Balance);
        }
        public void History()
        {
            foreach (string line in transaction)
            {
                Console.WriteLine(line);
            }
        } 
    }
}
