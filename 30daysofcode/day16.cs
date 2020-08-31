using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        
        try {
        int num = Convert.ToInt32(S);
        Console.WriteLine(num);
    }
    catch {
        Console.WriteLine("Bad String");
    }
    }
}