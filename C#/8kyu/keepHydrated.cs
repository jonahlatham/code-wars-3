// https://www.codewars.com/kata/582cb0224e56e068d800003c

using System;
using System.Linq;

public class Kata
{
    public static int Litres(double time)
    {
        return Convert.ToInt32(Math.Floor(time / 2));
    }
}

// // Better solution

public class Kata
{
    public static int Litres(double time)
    {
        return (int)(time / 2);
    }
}