// https://www.codewars.com/kata/54edbc7200b811e956000556/csharp

using System;
using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Where(e => e == true).ToArray().Length;
    }
}