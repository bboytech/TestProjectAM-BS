﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = new int[12];//declare an array of 12 integers called intArray1
            double[] dblArray1 = new double[10];//declare an array of 10 doubles  called dblArray1
            string[] strArray1 = new string[19]; //declare an array of 19  strings  called strArray1
            double[] dblArray2 = new double[18];//declare an array of 18  doubles  called dblArray2
            string[] strArray2 = new string[17];//declare an array of 17  strings  called strArray2
            int[] intArray2 = new int[12]; //declare an array of 15 integers called intArray2
            double[] dblArray3 = new double[3] { 2.45, 12.6, 15 };//declare an array of 3  doubles  called dblArray3 and initialize it to 2.45,12.6,15
            string[] strArray3 = new string[5] { "bob", "joe", "frank", "mary", "jane" };//declare an array of 5  strings  called strArray3 and initialize it to "bob","joe","frank","mary","jane"
            int[] intArray3 = new int[4] { 2, 4, 6, 8 };//declare an array of 4  integers called intArray3 and initialize it to 2,4,6,8
            int[] intArray4 = new int[2] { 128, 512 };//declare an array of 2  integers called intArray4 and initialize it to 128,512

            intArray1[0] = 13;//set element 0 of intArray1 to be 13
            intArray1[1] = 8;//set element 1 of intArray1 to be 8
            intArray1[5] = 9;//set element 5 of intArray1 to be 9
            intArray1[7] = 7;//set element 7 of intArray1 to be 7
            intArray1[9] = 6;  //set element 9 of intArray1 to be 6
            intArray1[10] = 12;//set element 10 of intArray1 to be 12

            dblArray1[0] = 13;//set the first element (element 0)of dblArray1 to be 13
            dblArray1[1] = 17.7;//set the second element (element 1)of dblArray1 to be 17.7
            dblArray1[3] = 21.512;//set the fourth element (element 3)of dblArray1 to be 21.512

            strArray1[0] = "This";//set the first element (element 0)of strArray1 to be "This"
            strArray1[5] = "is";//set the sixth element (element 5)of strArray1 to be "is"
            strArray1[3] = "fun";//set the fourth element (element 3)of strArray1 to be "fun"

            int var1 = intArray1[0];//read element 0 of intArray1 and put the result into a new variable var1
            int var2 = intArray1[1];//read element 1 of intArray1 and put the result into a new variable var2
            int var3 = intArray1[5]; //read element 5 of intArray1 and put the result into a new variable var3
            int var4 = intArray1[7] + intArray1[9];//add the values of element 7 and element 9 of intArray1 together and put into a variable called var4;
            int var5 = intArray1[7] + intArray1[10];//add the values of element 7 and element 10 of intArray1 together and put into a variable called var5;

            intArray1[2] = var1 + var2;//add var1 and var2 together and put the result into element 2 of intArray1
            intArray1[6] = var2 + var3;//add var2 and var3 together and put the result into element 6 of intArray1
            intArray1[8] = var4 + var5;//add var4 and var5 together and put the result into element 8 of intArray1

            dblArray1[0] = dblArray1[0] + dblArray1[3];//add the first element and the fourth element of dblArray1 and put the result into the first element of dblArray1
            dblArray1[1] = dblArray1[1] + dblArray1[3];//add the second element and the fourth element of dblArray1 and put the result into the second element of dblArray1
            dblArray1[3] = dblArray1[0] + dblArray1[3];//add the first element (this is the updated value from the last line) and the fourth element of dblArray1 and put the result into the fourth element of dblArray1

        
            Console.WriteLine(intArray1[0]);//print the value of the first element (element 0)
            Console.WriteLine(intArray1[5]);//print the value of the sixth element (element 5)
            Console.WriteLine(intArray1[3]);//print the value of the fourth element (element 3)

        }
    }
}
