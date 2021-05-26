using System.Linq;
using System;
using System.Collections.Generic;
public class Program
{
    public static string SpaceMeOut(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return String.Join(" ", charArray.Reverse());
    }
}
public class Program
{
	public static string SpaceMeOut(string str)
	{
		return String.Join(" ", str.ToArray());
	}
}