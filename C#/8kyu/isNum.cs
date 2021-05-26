using System;
public class CodeWars
{
    public static bool IsDigit(string s)
    {
        return int.TryParse(s, out _);
    }
}