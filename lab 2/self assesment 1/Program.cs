using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assesment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name, date, time;
            double amount;
            Console.WriteLine("Enter transaction id: ");
            id= Console.ReadLine();
            Console.WriteLine("Enter product namee: ");
            name= Console.ReadLine();
            Console.WriteLine("Enter amount: ");
            amount=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter date: ");
            date=Console.ReadLine();
            Console.WriteLine("Enter time: ");
            time=Console.ReadLine();
            Transaction t=new Transaction(id, name, amount, date, time);
            Transaction t1 = new Transaction ();
            t1 = t;
            Console.WriteLine(t1.TransactionID);
            Console.WriteLine(t.TransactionID);
            t1.TransactionID = "hellooooo";
            Console.WriteLine(t1.TransactionID);
            Console.WriteLine(t.TransactionID);
        }
    }
}
