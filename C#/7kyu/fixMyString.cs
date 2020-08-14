using System.Text.RegularExpressions;

public class Kata
{
    public static string IsItANum (string str)
    {
        string s = Regex.Replace (str, @"\D", "");
        return Regex.IsMatch (s, @"^0\d{10}$") ? s : "Not a phone number";
    }
}