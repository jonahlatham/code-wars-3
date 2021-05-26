using System.Linq;
public class Program
{
    public static string GetFilename(string path)
    {
        return path.Split('/').Last();
    }
}