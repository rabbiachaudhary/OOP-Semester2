using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileWRITE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\2nd semester\\oop lab\\lab1\\filehandling.txt";
            StreamWriter File=new StreamWriter(path,true);
            for(int i=0; i<19;i++)
            {
                File.WriteLine("helllo {0}", i);
            }
            File.Flush();
            File.Close();
        }
    }
}
