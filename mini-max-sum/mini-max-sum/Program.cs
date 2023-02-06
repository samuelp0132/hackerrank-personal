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
using Microsoft.VisualBasic.CompilerServices;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void minMaxSum(List<int> arr)
    {
        long min = arr[0], max = arr[0];
        long sum = 0;

        foreach (var item in arr)
        {
            sum += item;
            if (item >= max)
                max = item;
            if (item <= min)
                min = item;
        }
        
        Console.WriteLine($"{sum - max} {sum - min} ");
    }

}

class Program
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.minMaxSum(arr);
    }
}