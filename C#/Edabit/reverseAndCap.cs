using System.Linq;
using System;
using System.Collections.Generic;
public class Program
{
    public static string ReverseCapitalize(string str)
    {
        return string.Concat(str.Reverse()).ToUpper();
    }
}