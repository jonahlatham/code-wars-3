// https://www.codewars.com/kata/515e271a311df0350d00000f/javascript

using System;
using System.Linq;
public static class Kata
{
    public static int SquareSum(int[] n)
    {
        return n.Select(e => e * e).Sum();
    }
}

// // Better solution

public static class Kata
{
    public static int SquareSum(int[] n)
    {
        return n.Sum(x => x * x);
    }
}