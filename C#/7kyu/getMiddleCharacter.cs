using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static string GetMiddle1 (string s)
    {
        return s.Length % 2 == 0 ? s.Substring (s.Length / 2 - 1, 2) : s.Substring (s.Length / 2, 1);
    }

    public static string GetMiddle2 (string s)
    {
        return string.IsNullOrEmpty (s) ? s : s.Substring ((s.Length - 1) / 2, 2 - s.Length % 2);
    }
}