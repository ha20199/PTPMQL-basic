

public class Program
{
    private static void Main(string[] args)
    {
        int a=0;
        int b=0;
        Console.WriteLine("Nhap a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap b:");
        b = Convert.ToInt32(Console.ReadLine());
        int hieu = a - b;
        
        Console.WriteLine("Hieu a - b: " + hieu);
        Console.WriteLine("tich a * b: " + a*b) ;
        Console.WriteLine("chia lay nguyen a / b: " + a / b);
        Console.WriteLine("chia lay du a % b: " + a % b);
        if(a == b)
        {
            Console.WriteLine("a = b");
        }
        if(a > b)
        {
            Console.WriteLine("a > b");
        }
        if(a < b)
        {
            Console.WriteLine("a < b");
        }

    }
}