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

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        string bin = Convert.ToString(n, 2);
        int one = 0;
        int count = 0;
        
        for (int i = 0; i < bin.Length; i++) {
            if (bin[i] == '1') {
                one += 1;
            }
            else if (bin[i] == '0') {              
                one = 0;
            }
            
            if (one > count) {
                count = one;
            }
        }
        Console.WriteLine(count);
    }
}