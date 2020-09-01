using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FindMultiples (int integer, int limit)
    {
        var result = new List<int> ();
        var i = integer;

        while (i <= limit)
        {
            result.Add (i);
            i += integer;
        }

        return result;
    }
}