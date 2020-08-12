using System;
using System.Linq;

public class Solution
{
    public static int[] solve (int[] arr)
    {
        return arr.Reverse().Distinct().Reverse().ToArray();
    }
}