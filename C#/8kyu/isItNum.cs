using System.Text.RegularExpressions;
public class MyUtilities
{

    public boolean isDigit (String s)
    {
        Regex.IsMatch (s, @"^\d+$");
    }
}