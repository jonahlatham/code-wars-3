using System;
using System.Linq;
public static class StringExtensions
{
    public static bool IsUpperCase (this string text)
    {
        return text.ToUpper () == text;
    }
}