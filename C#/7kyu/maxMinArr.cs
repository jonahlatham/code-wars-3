 using System.Collections.Generic;
 using System.Linq;

 public static class Kata
 {
     public static List<int> Solve (List<int> arr)
     {
         return Enumerable.Range (0, arr.Count).Select (i => i % 2 == 0 ?
             arr.OrderByDescending (x => x).Skip (i / 2).First () :
             arr.OrderBy (x => x).Skip (i / 2).First ()).ToList ();
     }
 }