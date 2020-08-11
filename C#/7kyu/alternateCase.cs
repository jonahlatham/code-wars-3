using System;
using System.Linq;

namespace Solution
{
    public static class Program
    {
        public static string alternateCase (string s)
        {
            return string.Join ("", s.Select (e => e.ToString () == e.ToString ().ToUpper () ? e.ToString ().ToLower () : e.ToString ().ToUpper ()));
        }

        public static string alternateCaseBetterSolution (string s)
        {
            return string.Concat (s.Select (e => char.IsUpper (e) ? char.ToLower (e) : char.ToUpper (e)));
        }
    }
}