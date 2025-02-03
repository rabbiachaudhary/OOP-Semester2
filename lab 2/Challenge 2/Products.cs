using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Products
    {
        public string ID;
        public string name;
        public double price;
        public string category;
        public string brand;
        public string country;
        public Products(string a, string b , double c, string d , string e, string f)
        {
            ID=a; name=b; price=c; category=d; brand=e; country=f;
        }

        public static void Show()
        {
            Console.WriteLine("ID \t Name \t Price \t Category \t Brand \t Country");
            foreach (Products p in Program.products)
            {
                Console.WriteLine($"{p.ID} \t {p.name} \t {p.price} \t {p.category} \t {p.brand} \t {p.country}");
            }
        }
        public static void TotalWorth()
        {
            double total = 0;
            foreach (Products p in Program.products)
            {
                total += p.price;
            }
            Console.WriteLine("THE TOTAL WORTH : " + total);
        }
    }

}
