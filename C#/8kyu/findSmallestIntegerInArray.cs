using System;
using System.Linq;

public class Kata
{
    public static int FindSmallestInt1 (int[] args)
    {
        Array.Sort (args);
        return args[0];
    }

    public static int FindSmallestInt2 (int[] args)
    {
        return args.Min ();
    }
}
