using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();//create a list called myList that will hold integers

            double[] myArray = new double[10];//create an array called myArray that will hold 10 doubles

            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);
            myList.Add(11);
            myList.Add(13);
            myList.Add(15);
            myList.Add(17);
            myList.Add(19);//add the following values to myList: 1,3,5,7,9,11,13,15,17,19

            int k = 0;
            while (k < myArray.Length)
            {
                myArray[k] = myList[k] / 3;
                k = k + 1;
            }//using a loop initialize myArray to hold the values of myList/3  (Credit only given for using a loop) should be .333 , 1, 1.6667  etc

            //call the doStuffOnList function  passing in myList– (you will create the function below)
            //
            //create a function called doStuffOnList that takes a list of integers as an input
            int  c= 0;
            while (c < myList.Count)
            {
                myList[c] = myList[c] * 2;
                c = c + 1;
            }
            // this function should loop through all of the elements of the list passed in as an input
            // it should update each element in the list with its old value multiplied by 2.
            // changes made to the list in the function should change the list outside the function as 
            //well(list should be passed by reference - FYI this is done by default for lists/arrays in Java and C#)
            int a = 0;
            while (a < myList.Count)
            {
                Console.WriteLine(myList[a]);
                a = a + 1;
            }
            Console.WriteLine(" ");//loop through all the elements of myList and print out the values 

            int b = 0;
            while (b < myArray.Length)
            {
                Console.WriteLine(myArray[b]);
                b = b + 1;
            }
            Console.WriteLine(" ");//loop through all the elements of myArray and print out the values
        }
        
    }
}
