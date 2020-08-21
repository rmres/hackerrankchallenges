using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int testnum = Convert.ToInt32(Console.ReadLine());
        string str1 = "", str2 = "";
        for (int i = 0; i < testnum; i++)
        {
            string inputstr = Console.ReadLine();

            for (int i2 = 0; i2 < inputstr.Length; i2++)
            {
                if (i2 % 2 == 0)
                {
                    str1 = Convert.ToString(inputstr[i2]);
                    Console.Write(str1);
                }
            }
            Console.Write(" ");
            for (int i2 = 0; i2 < inputstr.Length; i2++)
            {
                if (i2 % 2 != 0)
                {
                    str2 = Convert.ToString(inputstr[i2]);
                    Console.Write(str2);
                }
            }
            Console.Write("\n");
        }
    }
}
