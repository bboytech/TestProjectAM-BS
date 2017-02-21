using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping_with_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //This assignment is to practice using loops to manipulate arrays
            // Create a program that does the following:
            
            int[] myIntArray1 = new int[50];//Declare an array of 50 integers called myIntArray1
            int[] myIntArray2 = new int[100];//Declare an array of 100 integers called myIntArray2
            int[] myIntArray3 = new int[100];//Declare an array of 100 doubles called myIntArray3
            double[] myDblArray1 = new double[200];//Declare an array of 200 doubles called myDblArray1

            int a = 0;
            while(a < myIntArray1.Length)
            {      
                if (a == 1)
                {
                     myIntArray1[1] = 0 + 1;
                }
                else if (a == 2)
                {
                     myIntArray1[2] = 3;
                }
                else if (a == 3)
                {
                    myIntArray1[3] = myIntArray1[2] + myIntArray1[3];
                }
                else if (a == 4)
                {
                     myIntArray1[4] = myIntArray1[3] + 4;
                }
                else
                {
                    myIntArray1[a] =a;                            
                }
                Console.WriteLine(myIntArray1[a]);
                a = a + 1;
            }    //set the elements of myIntArray1 to hold numbers 0-49;

            Console.WriteLine(" ");

            int b = 0;
            while (b < myIntArray2.Length)
            {
                myIntArray2[b] = b * 2;
                Console.WriteLine(myIntArray2[b]);
                b = b + 1;
            }    //set the elements of myIntArray2 to hold the first 100 even numbers

            Console.WriteLine(" ");

            int c = 0;
            int d = -1;
            while (c < myIntArray3.Length)
            {
                d = d + 2;
                myIntArray3[c] = d;
                Console.WriteLine(myIntArray3[c]);
                c = c + 1;
            }   //set the elements of myIntArray3 to hold the first 100 odd numbers

            Console.WriteLine(" ");

            int e = 0;
            double f = -.5;
            while (e < myDblArray1.Length)
            {
                f = f + .5; 
                myDblArray1[e] = f;
                Console.WriteLine(myDblArray1[e]);
                e = e + 1;
            }   //set the elements of myDblArray1 to hold 0-99.5 including every half number
                //////////////////////////

            Console.WriteLine(" ");

            //update the values of each element of myIntArray1 to be the current value + the value of the element before it.
            //Ex: if myIntArray1[0] == 0, myIntArray1[1] == 1, myIntArray1[2]==2, myIntArray1[3] ==3, and myIntArray1[4] ==4  then:
            // myIntArray1[0] should be unchanged (element 0 is first element)
            // myIntArray1[1] should be updated to be 1 (0+1)
            // myIntArray1[2] should be updated to be 3 (1+2)
            // myIntArray1[3] should be updated to be 6 (3+3) //note this uses the new value for element 2.
            // myIntArray1[4] should be updated to be 10 (6+4) //note this uses the new value for element 2.
            //etc.
        }
    }
}
