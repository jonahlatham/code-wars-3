using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum (int[] arr)
    {
        return arr.Where (e => e > 0).Sum ();
    }
}