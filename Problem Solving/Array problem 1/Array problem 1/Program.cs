using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_problem_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] nameArray = new string[10]{"Amy Beerhome", "Paul McCartwheel", "Brittany Speared", "Sue Ridge", "Bob Down", "Wacko Jackson", "Sidney Sparkle", "Bill Tarmac", "Bruce Fossil", "Madonna Kebab"};
            Console.WriteLine("Youre name?");
            string inputName = Console.ReadLine();
            if (inputName == nameArray[0])
            {
                Console.WriteLine("Please provide "+ nameArray [0] + " with a backstage pass.");
            }
            else if (inputName == nameArray[1])
            {
                Console.WriteLine("Please provide " + nameArray[1] + " with a backstage pass.");
            }
            else if (inputName == nameArray[2])
            {
                Console.WriteLine("Please provide " + nameArray[2] + " with a backstage pass.");
            }
            else if (inputName == nameArray[3])
            {
                Console.WriteLine("Please provide " + nameArray[3] + " with a backstage pass.");
            }
            else if (inputName == nameArray[4])
            {
                Console.WriteLine("Please provide " + nameArray[4] + " with a backstage pass.");
            }
            else if (inputName == nameArray[5])
            {
                Console.WriteLine("Please provide " + nameArray[5] + " with a backstage pass.");
            }
            else if (inputName == nameArray[6])
            {
                Console.WriteLine("Please provide " + nameArray[6] + " with a backstage pass.");
            }
            else if (inputName == nameArray[7])
            {
                Console.WriteLine("Please provide " + nameArray[7] + " with a backstage pass.");
            }
            else if (inputName == nameArray[8])
            {
                Console.WriteLine("Please provide " + nameArray[8] + " with a backstage pass.");
            }
            else if (inputName == nameArray[9])
            {
                Console.WriteLine("Please provide " + nameArray[9] + " with a backstage pass.");
            }
            else
            {
                Console.WriteLine("Sorry "+ inputName + "is not on the backstage list.");
            }
        }
    }
}
