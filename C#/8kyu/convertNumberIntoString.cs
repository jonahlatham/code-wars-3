using System;

public class Kata
{
    public static string NumberToString (int num)
    {
        return string.Join ("", num);
    }
    public static string StringToNumber (int num)
    {
        return Int32.Parse (num);
    }
}