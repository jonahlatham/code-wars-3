using System;
using System.Linq;
public class Kata
{
    public static int[] ArrayDiff (int[] a, int[] b)
    {
        return a.Where (e => !b.Contains (e)).ToArray();
    }
}