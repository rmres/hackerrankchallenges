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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        long sumMin = 0;
        long sumMax = 0;
        Array.Sort(arr);
        for (int i = 1; i < arr.Length; i++) {
            sumMax += arr[i];
        }
        for (int i = 0; i < arr.Length-1; i++) {
            sumMin += arr[i];
        }
        Console.WriteLine("{0} {1}", sumMin, sumMax);
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
