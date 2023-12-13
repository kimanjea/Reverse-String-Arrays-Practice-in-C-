# Reverse String Practice in C#
 Reversing a string for O(m+n) time complexity
# Killerman Program
The Killerman program is a C# console application that showcases the reversal of both strings and arrays. It consists of two classes, Solution and SolutionInt, each designed to handle the reversal of strings and arrays, respectively.

# Overview
# String Reversal:
The Solution class provides a method getthisreverse(string s) that takes a string s as input, reverses the words in the string, and then prints the reversed string.
***public class Solution {
    public string getthisreverse(string s) {
        // Implementation details as described below.
        Console.WriteLine(string.Join(' ', finalreverse));
        return "done";
    }
}***


# Array Reversal:
The SolutionInt class contains a method getthisarrayreverse(int[] j) that reverses an array of integers and prints the reversed array.
***public class SolutionInt {
    public void getthisarrayreverse(int[] j) {
        // Implementation details as described below.
        for (int i = 0; i < j.Length; i++) {
            Console.Write($"{j[i]},");
        }
    }
}***

# Usage
* String Reversal:
***string s = "let there be light";
var wellplayed = new Solution();
wellplayed.getthisreverse(s);***

* Array Reversal:
***int[] arrays = {1,2,3,4,5,6};
var welldone = new SolutionInt();
welldone.getthisarrayreverse(arrays);***