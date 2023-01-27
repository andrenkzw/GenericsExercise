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
        return EqualityComparer<T>.Default.Equals(x, y);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(1.Equals(1));
        Console.WriteLine(1.Equals<int>(1));
        Console.WriteLine(1.Equals(2));
        Console.WriteLine(1.Equals<int>(2));

        Console.WriteLine((1.0).Equals(1.0));
        Console.WriteLine((1.0).Equals<double>(1.0));
        Console.WriteLine((1.0).Equals(2.0));
        Console.WriteLine((1.0).Equals<double>(2.0));

        Console.WriteLine("1".Equals("1"));
        Console.WriteLine("1".Equals<string>("1"));
        Console.WriteLine("1".Equals("2"));
        Console.WriteLine("1".Equals<string>("2"));
    }
}
