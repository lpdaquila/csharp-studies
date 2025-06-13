namespace CSharpConsoleStudies.DataInputOutput;

class LogicalOperators
{
    public static void Comparsion()
    {
        System.Console.WriteLine("### Logical operators ###");

        int x = 10;
        int y = 20;

        System.Console.WriteLine($"X = {x}");
        System.Console.WriteLine($"Y = {y}");

        System.Console.WriteLine(x == y);

        bool result = x == y;
        System.Console.WriteLine(result);

        System.Console.WriteLine(x > y);
        System.Console.WriteLine(x < y);
        System.Console.WriteLine(x >= y);
        System.Console.WriteLine(x <= y);
        System.Console.WriteLine(x != y);
    }

    public static void Logical()
    {
        System.Console.WriteLine("### Logical Operators ###");

        bool c1 = 5 >= 7;
        bool c2 = 9 != 8;
        bool result;

        System.Console.WriteLine($"c1 = {c1}");
        System.Console.WriteLine($"c2 = {c2}");

        // AND -> &&
        result = c1 && c2;
        System.Console.WriteLine("AND (&&) -> " + result);

        // OR -> ||
        result = c1 || c2;
        System.Console.WriteLine("OR (||) -> " + result);

        // NOT -> !
        result = !c1;
        System.Console.WriteLine("NOT (!) -> " + result);
    }

    internal static void Precedence()
    {
        System.Console.WriteLine("### Precedence of Operators ###");

        // int x = 10 - 2 * 3; // *, /, %, +, -

        bool x = !(9 != 8) && 5 >= 7 || 8 >= 6; // = true
        bool y = !(9 != 8) && (5 >= 7 || 8 >= 6); // = false

        System.Console.WriteLine(x);
        System.Console.WriteLine(y);
    }

    public static void Ternary()
    {
        System.Console.WriteLine("### Ternary and unary operators ###");

        // Unary

        // int pos = 1;
        // int result;

        // result = +pos;
        // System.Console.WriteLine(result);

        // System.Console.WriteLine("Give a number:");
        // var n = Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine($"The negate of {n} is {-n}");

        // Ternary

        System.Console.WriteLine("Give the temperature: ");
        var temp = Convert.ToDouble(Console.ReadLine());

        var result = temp > 27 ? "Hot" :
                    temp < 12 ? "Cold" :
                    temp == 0 ? "Frozen" : "Normal";

        System.Console.WriteLine(result);


    }
}