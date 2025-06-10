namespace CSharpConsoleStudies.DataTypes;

public class FloatTypes
{
    public static void Print()
    {
        Console.WriteLine("Declarando variaveis numericas");
        Console.WriteLine();

        // Float, Double and Decimals

        Console.WriteLine("Float, double and decimal types");

        double n1 = 1.234;
        float n2 = 2.345f;
        decimal n3 = 3.456m;

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);

        Console.WriteLine("Testing the precision of float, double and decimal.");

        float x = 1f / 3f;
        double y = 1d / 3d;
        decimal z = 1m / 3m;

        Console.WriteLine($"Float: {x} \nDouble: {y} \nDecimal: {z}");

        Console.ReadLine();
    }
}