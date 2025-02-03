using System;
using System.Collections.Generic;

namespace Challenge_2
{
    internal class Program
    {
        public static List<Products> products = new List<Products>();

        static void Main(string[] args)
        {
            int opt;
            while (true)
            {
                Console.WriteLine("PRODUCTS MANAGEMENT SYSTEM");
                Console.WriteLine("Chose one option: ");
                Console.WriteLine("1. add products ");
                Console.WriteLine("2. show products");
                Console.WriteLine("3. total store worth ");
                Console.WriteLine("enter option...");
                opt=int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    AddProducts();
                }
                else if (opt == 2)
                {
                    Products.Show();
                    Console.ReadKey();
                }
                else if (opt == 3)
                {
                    Products.TotalWorth();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
        static void AddProducts()
        {
            string ID;
            string name;
            double price;
            string category;
            string brand;
            string country;
            Console.WriteLine("Enter id:");
            ID=Console.ReadLine();
            Console.WriteLine("Enter name: ");
            name=Console.ReadLine();
            Console.WriteLine("enter price: ");
            price=double.Parse(Console.ReadLine());
            Console.WriteLine("enter category: ");
            category=Console.ReadLine();
            Console.WriteLine("enter brand");
            brand=Console.ReadLine();
            Console.WriteLine("enter coounty");
            country=Console.ReadLine();
            Products product= new Products(ID,name,price, category, brand ,country);
            products.Add(product);
        }
        
    }
}
