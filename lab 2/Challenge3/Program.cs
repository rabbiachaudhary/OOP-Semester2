using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Challenge3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] username = new string[50];
            string[] pass = new string[50];
            string[] role = new string[50];
            int idx = 0;
            int currentMenu;
            string signin_username, signin_pass, signin_role;
            Console.Clear();
            readData(username, pass, role, ref idx);
            currentMenu = 0;
            while (true)
            {
                if (currentMenu == 0)
                {
                    Header();
                    string option = Signup_options();
                    if (option == "1")
                    {
                        Signup_Header();
                        if (Signup(ref idx))
                        {
                            writeData(username, pass, role, ref idx);
                            Console.WriteLine("                                                          signup successful");
                        }
                        else
                        {
                            Console.WriteLine("                                                          signup failed");
                        }
                        Console.WriteLine("                                                          Click on any key to return...");
                        Console.ReadKey();
                        idx++;
                    }
                    else if (option == "2")
                    {
                        Signin();
                        Console.WriteLine("                                                          Enter username: ");
                        signin_username = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("                                                          Enter passcode: ");
                        signin_pass = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("                                                          Enter Role: ");
                        signin_role = Console.ReadLine();
                        Console.WriteLine();
                        bool flag = false;
                        for (int i = 0; i < idx; i++)
                        {
                            if (signin_username == username[i] && signin_role == role[i] && signin_pass == pass[i])
                            {
                                Console.WriteLine("                                                          sign in successful");
                                Console.WriteLine("                                                          spress any key to continue..");
                                Console.ReadKey();
                                flag = true;
                                if (signin_role == "Admin" || signin_role == "admin")
                                {
                                    currentMenu = 1;
                                }
                                if (signin_role == "Manager" || signin_role == "manager")
                                {
                                    currentMenu = 2;
                                }
                                if (signin_role == "Customer" || signin_role == "customer")
                                {
                                    currentMenu = 3;
                                }
                                break;
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("                                                          You have entered incorrect information");
                            Console.WriteLine("                                                          Press any key to conitnue...");
                            Console.ReadKey();
                        }
                    }
                    else if (option == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("                                                             Incorrect option");
                        Console.WriteLine("                                                             Press any kry to continue..");
                        Console.ReadKey();
                    }
                }
            }
        }

        static void Header()
        {
            Console.Clear();
            Console.SetCursorPosition(20, 12);
            Console.WriteLine(" __    __    ______    __       __       _______..___________. __    ______     __    __   __    __  .______    ");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("|  |  |  |  /  __  \\  |  |     |  |     /       ||           ||  |  /      |   |  |  |  | |  |  |  | |   _  \\   ");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("|  |__|  | |  |  |  | |  |     |  |    |   (----``---|  |----`|  | |  ,----'   |  |__|  | |  |  |  | |  |_)  |  ");
            Console.SetCursorPosition(20, 15);
            Console.WriteLine("|   __   | |  |  |  | |  |     |  |     \\   \\        |  |     |  | |  |        |   __   | |  |  |  | |   _  <   ");
            Console.SetCursorPosition(20, 16);
            Console.WriteLine("|  |  |  | |  `--'  | |  `----.|  | .----)   |       |  |     |  | |  `----.   |  |  |  | |  `--'  | |  |_)  |  ");
            Console.SetCursorPosition(20, 17);
            Console.WriteLine("|__|  |__|  \\______/  |_______||__| |_______/        |__|     |__|  \\______|   |__|  |__|  \\______/  |______/   ");
            Console.SetCursorPosition(20, 18);
            Console.WriteLine("                                                                                                                ");
            Console.WriteLine();
        }
        static void Signup_Header()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("                                                            ____   _                              ");
            Console.WriteLine("                                                           / ___| (_)  __ _  _ __   _   _  _ __  ");
            Console.WriteLine("                                                           \\___ \\ | | / _` || '_ \\ | | | || '_ \\");
            Console.WriteLine("                                                            ___) || || (_| || | | || |_| || |_) |");
            Console.WriteLine("                                                           |____/ |_| \\__, ||_| |_| \\__,_|| .__/ ");
            Console.WriteLine("                                                                      |___/               |_|     \n ");
        }
        static void Signin()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("                                                            ____   _                _         ");
            Console.WriteLine("                                                           / ___| (_)  __ _  _ __  (_) _ __   ");
            Console.WriteLine("                                                           \\___ \\ | | / _` || '_ \\ | || '_ \\  ");
            Console.WriteLine("                                                            ___) || || (_| || | | || || | | | ");
            Console.WriteLine("                                                           |____/ |_| \\__, ||_| |_||_||_| |_| ");
            Console.WriteLine("                                                                      |___/                  ");
        }
        static string Signup_options()
        {
            string option;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                             Select your option");
            Console.WriteLine("                                                             1. Signup");
            Console.WriteLine("                                                             2. Signin");
            Console.WriteLine("                                                             3. Exit");
            Console.WriteLine("                                                             Enter Option: ");
            option = Console.ReadLine();
            return option;
        }
        static bool Signup(ref int idx)
        {
            string n, p, r;
            Console.WriteLine("                                                          Enter username: ");
            n = Console.ReadLine();
            while (!(IsAplphabetOny(n)) || !(FirstLetterCapital(n)) || (LenghtOfString(n) < 4))
            {
                Console.WriteLine("                                                          The username must begin with a capital letter.");
                Console.WriteLine("                                                          The username must have atleast 4 aplphabets.");
                Console.WriteLine("                                                          Enter username: ");
                n = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("                                                          Enter passcode: ");
            p = Console.ReadLine();
            while (!IsAlNum(p) || (LenghtOfString(p) < 6))
            {
                Console.WriteLine("                                                          Password should contain atleast 6 characters.");
                Console.WriteLine("                                                          Only Numbers and letters should be used..");
                Console.WriteLine("                                                          Enter passcode:");
                p = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("                                                          Enter role (Admin, Customer, Manager): ");
            r = Console.ReadLine();
            Console.WriteLine();
            if (r == "Admin" || r == "Customer" || r == "Manager" || r == "admin" || r == "customer" || r == "manager")
            {
                MUser muser = new MUser(n, p, r);
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsAplphabetOny(string x)
        {
            for (int i = 1; i < x.Length; i++)
            {
                if (!((x[i] >= 'a' && x[i] <= 'z') || (x[i] >= 'A' && x[i] <= 'Z')))
                {
                    return false;
                }
            }
            return true;
        }

        static bool FirstLetterCapital(string x)
        {
            if (!(x[0] >= 'A' && x[0] <= 'Z'))
            {
                return false;
            }
            return true;
        }

        static bool IsNumberOnly(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if ((x[i] < '0' || x[i] > '9'))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsAlNum(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (!Char.IsLetterOrDigit(x[i]))
                {
                    return false;
                    break;
                }
            }
            return true;
        }

        static int LenghtOfString(string x)
        {
            int count = 0;
            for (int i = 0; i <= x.Length; i++)
            {
                count++;
            }
            return count;
        }
        static string getField(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int idx = 0; idx < record.Length; idx++)
            {
                if (record[idx] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    item += record[idx];
                }
            }
            return item;
        }
        static void writeData(string[] username, string[] pass, string[] role, ref int idx)
        {
            string path = "D:\\2nd semester\\oop submissions\\signup\\credentials.csv";
            StreamWriter fwrite = new StreamWriter(path, true);
            string line;
            fwrite.WriteLine(username[idx] + "," + pass[idx] + "," + role[idx]);
            fwrite.Flush();
            fwrite.Close();
        }
        static void readData(string[] username, string[] pass, string[] role, ref int idx)
        {
            string record;
            string path = "D:\\2nd semester\\oop submissions\\signup\\credentials.csv";
            StreamReader data = new StreamReader(path);

            while ((record = data.ReadLine()) != null)
            {
                record = data.ReadLine();
                username[idx] = getField(record, 1);
                pass[idx] = getField(record, 2);
                role[idx] = getField(record, 3);
                idx++;
            }
            data.Close();
        }
    }
}
