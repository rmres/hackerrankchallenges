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

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> gradeslist = new List<int>();

        foreach(int i in grades) {
            int nextmultipleoffive = i;

            if (i < 38) {
                gradeslist.Add(i);
            }

            else if (i >= 38) {
                bool done = false;
                do {
                    if (nextmultipleoffive % 5 == 0) {
                        done = true;
                    }
                    nextmultipleoffive++;
                }
                while (done == false);

                if ((nextmultipleoffive - 1) - i < 3) {
                    nextmultipleoffive -= 1;
                    gradeslist.Add(nextmultipleoffive);
                }
                else {
                    gradeslist.Add(i);
                }
            }
        }
        return gradeslist;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
