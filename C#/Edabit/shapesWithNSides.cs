public class Program
{
    public static string NSidedShape(int n)
    {
        var crap = new string[] { "circle", "semi-circle", "triangle", "square", "pentagon", "hexagon", "heptagon", "octagon", "nonagon", "decagon" };
        return crap[n - 1];
    }
}