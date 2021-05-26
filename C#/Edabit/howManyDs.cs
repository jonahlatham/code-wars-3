using System.Linq;
using System;
using System.Collections.Generic;
public class Program
{
    public static int CountDs(string str)
    {
        return str.Where(c => (c == 'd' || c == 'D')).Count();
    }
}