using System;
using System.Linq;
public static class Kata
{
    public static string Solution1 (string str)
    {
        return new string (str.ToCharArray ().Reverse ().ToArray ());
    }

    public static string Solution2 (string str)
    {
        return string.Concat (str.Reverse ());
    }
}