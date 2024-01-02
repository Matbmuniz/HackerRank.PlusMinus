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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        bool passedPositive = false;
        bool passedNegative = false;
        bool passedZero = false;
        for (int i = 0; i < arr.Count; i++)
        {
            var count = arr.Count;
            CultureInfo culInfo = CultureInfo.CurrentCulture;

            if (passedPositive == false)
            {
                passedPositive = true;
                int countPositive = arr.Where(x => x > 0).Count();
                var r = Convert.ToDecimal(countPositive, culInfo) / Convert.ToDecimal(count, culInfo);
                Console.WriteLine(r.ToString("0.000000") + "\r");
            }
            else if (passedNegative == false)
            {
                passedNegative = true;
                int countNegative = arr.Where(x => x < 0).Count();
                var r = Convert.ToDecimal(countNegative, culInfo) / Convert.ToDecimal(count, culInfo);
                Console.WriteLine(r.ToString("0.000000") + "\r");
            }
            else if (passedZero == false)
            {
                passedZero = true;
                int countZero = arr.Where(x => x == 0).Count();
                var r = Convert.ToDecimal(countZero, culInfo) / Convert.ToDecimal(count, culInfo);
                Console.WriteLine(r.ToString("0.000000") + "\r");
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
