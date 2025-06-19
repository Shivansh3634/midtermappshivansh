namespace MidtermApp;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Multiply(int a, int b) => a * b;
    public int Subtract(int a, int b) => a - b;
    public int Divide(int a, int b) => b != 0 ? a / b : 0;
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Midterm App by Shivansh (8983634)");
    }
}
