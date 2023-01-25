namespace Generics;
static class Program
{
    public static bool Equals(this int x, int y)
        => x == y;
    public static bool Equals(this double x, double y)
        => x == y;
    public static bool Equals(this string x, string y)
        => x == y;
    public static bool Equals<T>(this T x, T y)
    {
        if (x == null)
        {
            return y == null;
        }
        return x.Equals(y);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
