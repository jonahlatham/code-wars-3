using System;
using System.Linq;
public class Kata
{
    public static string AbbrevName1 (string name)
    {
        var newName = name.Split (" ");
        return $"{string.Join("", newName[0][0]).ToUpper()}.{string.Join("", newName[1][0]).ToUpper()}";
    }
    public static string AbbrevName2 (string name)
    {
        return string.Join (".", name.Split (" ").Select (e => e[0])).ToUpper ();
    }
}