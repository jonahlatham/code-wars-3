using System.Linq;
using System;
using System.Collections.Generic;
public class Program
{
    public static string Repetition(string txt, int n)
    {
        return string.Concat(Enumerable.Repeat(txt, n));
    }
}