using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static int SquareDigits (int n)
    {
        return int.Parse (String.Concat (n.ToString ().Select (e => (int) Math.Pow (char.GetNumericValue (e), 2))));
    }
}