using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
            int negative = 0;
            int positive = 0;
            int zeros = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] < 0) {
                negative += 1;
            }
            else if (arr[i] == 0) {
                zeros += 1;
            }
            else {
                positive += 1;
            }  
        }           
            double line1 = (double)positive/arr.Length;
            double line2 = (double)negative/arr.Length;
            double line3 = (double)zeros/arr.Length;

            Console.WriteLine("{0:0.000000}", line1);
            Console.WriteLine("{0:0.000000}", line2);
            Console.WriteLine("{0:0.000000}", line3);      
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
