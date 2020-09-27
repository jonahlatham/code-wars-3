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

     public static List<int> Solve2 (List<int> arr)
     {
         arr = arr.Distinct ().OrderByDescending (i => i).ToList ();
         var result = new List<int> ();
         for (var i = 0; i < Math.Ceiling (arr.Count / 2.0); i++)
         {
             result.Add (arr[i]);
             if (i < arr.Count / 2)
                 result.Add (arr[arr.Count - 1 - i]);
         }

         return result;
     }
 }