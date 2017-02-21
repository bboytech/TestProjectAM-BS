using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_with_lists_WH__1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>(); //declare a list  of integers called intList
            List<double> dblList = new List<double>(); //declare a list of doubles  called dblList
            List<string> strList = new List<string>(); //declare a list of strings  called strList
            List<bool> boolList = new List<bool>(); //declare a list of bools called boolList

            ////////////////////////////////////////////////////////////////////////////////////

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            //add the following elements to intList : 1,2,3,4,5

            dblList.Add(123.4);
            dblList.Add(43.4);
            dblList.Add(12.4);
            dblList.Add(65.7);
             //add the following elements to dblList: 123.4,43.4,12.4,65.7

            strList.Add("what");
            strList.Add(" did one");
            strList.Add(" ocean");
            strList.Add(" say one");
            strList.Add(" hte other");
            //add the following elements to strList: "What", " did one"," ocean"," say to"," the  other?"

            boolList.Add(true);
            boolList.Add(true);
            boolList.Add(false);
            //add the following elements to bool List: true, true, false

            ////////////////////////////////////////////////////////////////////////////////////

            intList[0] = 13;//set element 0 of intList to be 13
            intList[1] = 8;//set element 1 of intList to be 8
            intList[2] = 9;//set element 2 of intList to be 9
            intList[3] = 7;//set element 3 of intList to be 7
            intList[4] = 6;//set element 4 of intList to be 6

            //////////////////////////////////////////////////////////////////////

            dblList[0] = 13;//set the first element (element 0)of dblList to be 13
            dblList[1] = 17.7;//set the second element (element 1)of dblList to be 17.7
            dblList[3] = 21.512;//set the fourth element (element 3)of dblList to be 21.512

            /////////////////////////////////////////////////////////////////////////

            int k = 0;
            while (k < intList.Count())
            {
                Console.WriteLine(intList[k]);
                k = k + 1;
            }
            Console.WriteLine(" ");//print out all of the values of intList  - for the printing reccommend using loops 

            int l = 0;
            while (l < dblList.Count())
            {
                Console.WriteLine(dblList[l]);
                l = l + 1;
            }
            Console.WriteLine(" ");//print out all of the values of dblList  - also might want to put into function

            int j = 0;
            while (j < strList.Count())
            {
                Console.WriteLine(strList[j]);
                j = j + 1;
            }
            Console.WriteLine(" ");//print out all of the values of strList

            ////////////////////////////////////////////////////////////////////////////////

            strList[3] = (" just");//set the fourth element (element 3)of strList to be " just"
            strList[1] = (", ");//set the second element (element 1)of strList to be ", "
            strList[4] = (" waved");//set the fifth element  (element 4)of strList to be " waved."
            strList[2] = (" it");//set the third element  (element 2)of strList to be " it"
            strList[0] = ("Nothing");//set the first element  (element 0)of strList to be "Nothing"

            ////////////////////////////////////////////////////////////////////////////////

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            intList.Add(9);
            intList.Add(10);
            //add the following elements to intList 1,2,3,4,5,6,7,8,9,10

            dblList.Add(12);
            dblList.Add(2.3);
            dblList.Add(5.43);
            //add the following elements to dblList 12,2.3,5.43

            ///////////////////////////////////////////////////

            Console.WriteLine(" ");
            Console.WriteLine(intList.Count);//print out the number of elements in intList
            Console.WriteLine(dblList.Count);//print out the number of elements in dblList
            Console.WriteLine(strList.Count);//print out the number of elements in strList
            Console.WriteLine(" ");

            ///////////////////////////////////////////////////
            int a = 0;
            while (a < intList.Count())
            {
                Console.WriteLine(intList[a]);
                a = a + 1;
            }
            Console.WriteLine(" ");//print out all of the values of intList  - for the printing reccommend using loops

            int b = 0;
            while (b < dblList.Count())
            {
                Console.WriteLine(dblList[b]);
                b = b + 1;
            }
            Console.WriteLine(" ");//print out all of the values of dblList  - also might want to put into a function

            int c = 0;
            while (c < strList.Count())
            {
                Console.WriteLine(strList[c]);
                c = c + 1;
            }
            Console.WriteLine(" ");//print out all of the values of strList

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            strList[3] = (" when he");//set the fourth element (element 3)of strList to be " when he"
            strList[1] = ("you call");//set the second element (element 1)of strList to be "you call "
            strList[4] = (" skips church?");//set the fifth element  (element 4)of strList to be " skips church?"
            strList[2] = (" Batman");//set the third element  (element 2)of strList to be "Batman"
            strList[0] = ("what do ");//set the first element  (element 0)of strList to be "What do "

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            int d = 0;
            while (d < strList.Count())
            {
                Console.WriteLine(strList[d]);
                d = d + 1;
            }
            Console.WriteLine(" ");//print out all of the values of strList

            //////////////////////////////////////////////////////////////////////////////////

            strList.Add("Cgristian ");//add "Christian" to strList
            strList.Add("Bale");//add "Bale" to strList

            ////////////////////////////////////////////////////////////////////////////////

            int e = 0;
            while (e < strList.Count())
            {
                Console.WriteLine(strList[e]);
                e = e + 1;
            }
            Console.WriteLine(" ");//print out all of the values of strList

            /////////////////////////////////////////////////////////////////////////////

            strList[3] = (" round");//set the fourth element (element 3)of strList to be " round"
            strList[1] = ("Invented");//set the second element (element 1)of strList to be "Invented "
            strList[5] = (" Cumferende");//set the sixth element  (element 5)of strList to be " Cumference "
            strList[4] = (" table?");//set the fifth element  (element 4)of strList to be " table?"
            strList[2] = ("the");//set the third element  (element 2)of strList to be "the"
            strList[5] = (" Sir");//set the sixth element  (element 5)of strList to be " Sir "
            strList[0] = ("Who ");//set the first element  (element 0)of strList to be "Who "
            
            //////////////////////////////////////////////////////////////////////////////////////

            int f = 0;
            while (f < strList.Count())
            {
                Console.WriteLine(strList[f]);
                f = f + 1;
            }
            Console.WriteLine(" "); //print out all of the values of strList

        }
    }
}
