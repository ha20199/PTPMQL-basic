

public class Program
{
    private static void Main(string[] args)
    {
        Pratice pratice = new Pratice();
        Console.WriteLine("Bien so:");
        Console.WriteLine("Int " + pratice.Int);
        Console.WriteLine("Long " + pratice.Long);
        Console.WriteLine("Float " + pratice.Float);
        Console.WriteLine("Double " + pratice.Double);
        Console.WriteLine("Decimal " + pratice.Decimal);
        Console.WriteLine("Booleans " + pratice.Booleans);
        Console.WriteLine("Char " + pratice.Char);
        Console.WriteLine("String " + pratice.String);
        Console.WriteLine("_________________________________________");
        Console.WriteLine("Hang so:");
        Console.WriteLine("Int " + Pratice_Const.Int);
        Console.WriteLine("Long " + Pratice_Const.Long);
        Console.WriteLine("Float " + Pratice_Const.Float);
        Console.WriteLine("Double " + Pratice_Const.Double);
        Console.WriteLine("Decimal " + Pratice_Const.Decimal);
        Console.WriteLine("Booleans " + Pratice_Const.Booleans);
        Console.WriteLine("Char " + Pratice_Const.Char);
        Console.WriteLine("String " + Pratice_Const.String);
    }


}

public class Pratice
{
    public int Int = 10;
    public long Long = 20;
    public float Float = 5.4f;
    public double Double = 1200.99;
    public decimal Decimal = 900;
    public bool Booleans = true;
    public char Char = 'L';
    public string String = "Hello, World!";
}

public class Pratice_Const
{
    public const int Int = 10;
    public const long Long = 20;
    public const float Float = 5.4f;
    public const double Double = 1200.99;
    public const decimal Decimal = 900;
    public const bool Booleans = true;
    public const char Char = 'L';
    public const string String = "Hello, World!";
}