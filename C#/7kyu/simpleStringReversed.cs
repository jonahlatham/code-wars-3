using System.Collections;
using System.Linq;

public class Solution
{
    public static string solve (string s)
    {
        var withoutSpacesStack = new Stack (s.Replace (" ", "").ToList ());
        return string.Concat (s.Select (c => c != ' ' ? withoutSpacesStack.Pop () : ' '));
    }
}