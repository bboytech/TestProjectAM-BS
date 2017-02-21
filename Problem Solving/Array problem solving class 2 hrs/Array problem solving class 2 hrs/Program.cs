using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_problem_solving_class_2_hrs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startEnergy = 0;
            int[] arr = new int[4]{ 3, -4, 7, 5};
            int curEngergy = startEnergy;
            int i = 0;
            while (i <= 3)
            {
                curEngergy = arr[i] + curEngergy;
                if (startEnergy > curEngergy)
                {
                    startEnergy = (-1 * curEngergy) + startEnergy;
                    Console.WriteLine("Your start energy should be " + startEnergy);
                }
                i = i + 1;         
            }
        }
    }
}
