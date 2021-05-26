public class Program
{
    public static string Stutter(string word)
    {
        return $"{word.Substring(0, 2)}... {word.Substring(0, 2)}... {word}";
    }
}