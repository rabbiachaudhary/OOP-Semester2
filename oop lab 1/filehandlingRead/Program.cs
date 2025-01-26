using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filehandlingRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\2nd semester\\oop lab\\lab1\\read.txt";
            if(File.Exists(path))

            {
                StreamReader File = new StreamReader(path);
                string record;
                while((record=File.ReadLine())!=null)
                {
                    Console.WriteLine(record);
                }
                File.Close();
            }
            else
            {
                Console.WriteLine("File doesnt exist");
            }
        }
    }
}
