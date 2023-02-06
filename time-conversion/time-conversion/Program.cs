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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var dateWithoutHours = s.Substring(2, s.Length - 2);
        var dateWithoutTimeSystem = dateWithoutHours.Substring(0, dateWithoutHours.Length - 2);
        string hours = s.Substring(0, 2);
        var timeSystem = s.Substring(s.Length - 2, 2);
        
        if(timeSystem.Equals("PM") && Int32.Parse(hours) < 12){
            hours = (Int32.Parse(hours) + 12).ToString();
        }
        else if(timeSystem.Equals("AM") && hours == "12"){
            hours = "0" + (Int32.Parse(hours) - 12).ToString();
        }
        
        return String.Concat(hours,dateWithoutTimeSystem);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);
        
        Console.WriteLine(result);
    }
}