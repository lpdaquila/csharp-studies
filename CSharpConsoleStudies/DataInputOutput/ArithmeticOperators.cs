namespace CSharpConsoleStudies.DataInputOutput;

class ArithmeticOperators
{
    public static void Operators()
    {
        System.Console.WriteLine("X value:");
        int x = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Y value:");
        int y = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"Sqrt of x = {Math.Sqrt(x)}");
        System.Console.WriteLine($"Power of x^y = {Math.Pow(x, y)}");
        System.Console.WriteLine($"Min of x and y = {Math.Min(x, y)}");
        System.Console.WriteLine($"Max of x and y = {Math.Max(x, y)}");
        System.Console.WriteLine($"Cos of x = {Math.Cos(x)}");
        System.Console.WriteLine($"Sin of x = {Math.Sin(x)}");
        System.Console.WriteLine($"Exp of x = {Math.Exp(x)}");

        Console.ReadKey();

        // System.Console.WriteLine($"Sum of x + y = {x + y}");
        // System.Console.WriteLine($"Subtraction of x - y = {x - y}");
        // System.Console.WriteLine($"Multiplication of x * y = {x * y}");
        // System.Console.WriteLine($"Division of x / y = {(double)x / y}"); // to a precision result
        // System.Console.WriteLine($"Module of x % y = {x % y}");

    }
}