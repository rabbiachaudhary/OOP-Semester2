using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KamyabLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Path = "C:\\Users\\This PC\\source\\repos\\oop lab 1\\KamyabLife\\pizza.txt";

            Pizza_points(min_order,min_price);
        }
        static void Pizza_points(int min_order, int min_price)
        { 

        }
        static void readData()
        {
            string Path = "C:\\Users\\This PC\\source\\repos\\oop lab 1\\KamyabLife\\pizza.txt";
            StreamReader read = new StreamReader(Path);
            string record = "";

            string name = "";
            while((record=read.ReadLine()) != null)
            {
                name=record.Insert(0,name);
            }
        }
    }

}
