using System;
using System.Linq;

public static class Kata 
{
    public static int summation(int num)
    {
      return Enumerable.Range(1, num).Sum();
    }
}

// // other solution
// public static class Kata 
// {
//     public static int summation(int num)
//     {
//       return num*(num+1)/2;
//     }
// }