using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string timeConversion(string s) {
        char[] arr = s.ToCharArray(2, 6);
        string timeconv = "";
        string a = Convert.ToString(s[0]) + Convert.ToString(s[1]);
        if (s[s.Length-2] == 'P') {
            if (a == "12") {
                timeconv = "12";
            }
            else { 
            timeconv = Convert.ToString(Convert.ToInt32(a) + 12);
            }
            
            string chartostring = new string(arr);
            timeconv = timeconv + chartostring;
        }
        else if (s[s.Length-2] == 'A') {
            if (a == "12") {
                a = "00";
            }
            
            string chartostring = new string(arr);
            timeconv = a + chartostring;
        }
        return timeconv;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
