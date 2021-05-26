using System.Linq;
using System;
using System.Collections.Generic;
public class Program
{
    public static int[] HashPlusCount(string s)
    {
        return new int[] { s.Count(x => x == '#'), s.Count(x => x == '+') };
    }
}