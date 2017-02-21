using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Login__2hr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that does the following:

            List<string> usernameList = new List<string>();
            List<string> name = new List<string>();
            List<string> password = new List<string>();
            string checkUsername;

            int c = 0;
            while (true)
            {
                Console.WriteLine("enter a username or Create Account?");//1.)prompt the user to "enter a username or type "Create Account" "
                string choice1 = Console.ReadLine();
                if (choice1 == "enter a username")
                {
                    Console.WriteLine("enter your username");
                    string user = Console.ReadLine();
                    Console.WriteLine("enter your password");//3.)ask the user for a correspoding password
                    string Corpass = Console.ReadLine();
                    int d = 0;
                    while (d < usernameList.Count)//4.)check if username and password pair match existing entries.
                    {
                        if (user == usernameList[d])
                        {
                            Console.WriteLine("Welcome " + user + ".");//5.)if they do print "welcome " + name . and exit the program
                            break;
                        }
                        else
                        {
                            d = d + 1;//6.)if they do not match an existing entry prompt user "invalid credentials" and go back to 1.
                            break;
                        }
                    }
                }
                else if (choice1 == "Create Account")//2.)if they typed "Create Account"
                {
                    Console.WriteLine("Enter a username to create ure account");//2a)     ask them to enter a username, 
                    while (true)
                    {
                        checkUsername = Console.ReadLine();
                        int a = 0;
                        int b = 0;
                        while (a > usernameList.Count)
                        {
                            if (checkUsername == usernameList[a])
                            {
                                b = b + 1;
                            }
                            else
                            {
                                b = 0;
                            }
                            a = a + 1;
                        }
                        if (b == 1)
                        {
                            continue; //2b)     check if username already exist if it does go back to 2a
                        }
                        break;
                    }

                    Console.WriteLine("enter your name");//2c)     ask them to enter their name,
                    string name1 = Console.ReadLine();

                    while (true)
                    {
                        Console.WriteLine("Enter a password");//2d)     ask them to enter a password,
                        string passw = Console.ReadLine();

                        Console.WriteLine("Enter to confirm password"); //2e)     ask them to confirm password,
                        string passw2 = Console.ReadLine();

                        if (passw == passw2)
                        {
                            usernameList[c] = checkUsername;
                            name[c] = name1;
                            password[c] = passw;
                            //2g)     it should create the account (add username, name, and password to correspoding lists) then go back to 1.
                        }
                        else
                        {
                            continue;//2f)     if the passwords do not match go back to 2d
                        }
                    }
                    c = c + 1;
                }
            }   
        }
    }
}
