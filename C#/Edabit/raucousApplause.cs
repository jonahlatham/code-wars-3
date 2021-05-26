using System.Linq;
public class Program
{
    public static int CountClaps(string txt)
    {
        return txt.Count(x => x == 'C');
    }
}