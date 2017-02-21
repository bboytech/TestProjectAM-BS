using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End_of_Arrays_project___4_WH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[100];            
            int[][] score = new int[100][];
            int i = 0;
            while (i < 99)
            {
                Console.WriteLine("Enter a student name");
                studentName[i] = Console.ReadLine();
                int[] tempScore1 = new int[40];
                int k = 0;
                while (k < 39)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("enter a score");
                            tempScore1[k] = Convert.ToInt32(Console.ReadLine());
                            k = k + 1;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Bad Input must be a number");
                            continue;
                        }
                        break;
                    }
             }
                score[i] = tempScore1; 
                i = i + 1;
          }

            //////////////////////////////////////////////////////////////

            int a = 0;
            
            string name;
            while (a < 99)
                {
                Console.WriteLine("Enter a student name to get an average score");
                name = Console.ReadLine();
                int b = 0;
                while (b < 99)
                {
                    if (name == studentName[b])
                    {
                        double total = 0;
                        for (int c=0; c < score[b].Length; c = c + 1)
                        {
                            total = total + Convert.ToDouble(score[b]);
                        }
                        total = total / 40;
                        Console.WriteLine(name + " average is "+ total);
                        break;
                    }
                    else
                    {
                        b = b + 1;
                    }
                }

                }
        }
    }
}
