using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int i2 = 0;
        double d2 = 0;
        string s2 = "";
        double sum = 0.0;

        i2 = int.Parse(Console.ReadLine());
        d2 = double.Parse(Console.ReadLine());
        s2 = Console.ReadLine();

        sum = d+d2;

        Console.WriteLine(i+i2);
        Console.WriteLine("{0:0.0}",sum);
        Console.WriteLine(s+s2);
        
        // Declare second integer, double, and String variables.
        
        // Read and save an integer, double, and String to your variables.
        
        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}