using System;
using System.IO.Compression;

namespace Killerman {

    class Program {
        static void Main(string [] args) {


            string s= "let there be light";// we create our string
            var wellplayed = new Solution();// we create a new instance of class wellplayed
            wellplayed.getthisreverse(s);// we call the getthisreverse method

            int [] arrays = {1,2,3,4,5,6};// we create our array
            var welldone = new SolutionInt();//we create a new instance of class called welldone
            welldone.getthisarrayreverse(arrays);// call the getthisarrayreverse method

        }

       public class Solution {//this is the class we call to perform a reverse on any string 
            public string getthisreverse(string s) { // we have to retrung a string since our function is not void

                string reverse= new string (s.Reverse().ToArray()); // we create a new string that performs a reverse on s and also changes it to an array

                string [] finalreverse = reverse.Split(' ');// we split the array by spaces, if yours is different, choose how you split it

                Array.Reverse(finalreverse);//arrays have a reverse function that is performed on them

                Console.WriteLine(string.Join(' ',finalreverse)); // we print out our new array joined by spaces.

                return "done";
            }

        }

        public class SolutionInt {// this is the class we call to perform a reverse on any array
            public void getthisarrayreverse(int [] j) {                
                Array.Reverse(j);//this method helps do the reverse on our array

                for (int i = 0; i < j.Length; i++)
                {
                    Console.Write($"{j[i]},");//we print out each of our array elements
                } 
                // we don't have to return something since our function is void
            }
        }
    }

}