using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

        string test;
        int n = Convert.ToInt32(Console.ReadLine());
        var phonebook = new Dictionary<string, string>();
        string[] person = new string[n];
        for (int i = 0; i < n; i++) {
            person = Console.ReadLine().Split(' ');
            phonebook.Add(person[0], person[1]);
        }
        while((test = Console.ReadLine()) != null) {
            if (phonebook.ContainsKey(test)) {
                Console.Write("{0}=", test);
                Console.WriteLine("{0}", phonebook[test]);
            }
            else {
                Console.WriteLine("Not found");
            }
        }
    }
}
