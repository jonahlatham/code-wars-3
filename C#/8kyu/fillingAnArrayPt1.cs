using System;
using System.Linq;

public class Kata
{
    public static int[] Arr (int num)
    {
        return Enumerable.Range (0, num).ToArray ();
    }
}