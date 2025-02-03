using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assesment_1
{
    public class Transaction
    {
        public string TransactionID;
        public string ProductName;
        public double Amount;
        public string Date;
        public string Time;
        public Transaction(string id, string name, double amount, string date, string time)
        {
            TransactionID = id;
            ProductName = name;
            Amount = amount;
            Date = date;
            Time = time;
        }
        public Transaction() { }    
    }
}
