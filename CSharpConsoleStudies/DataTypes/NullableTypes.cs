namespace CSharpConsoleStudies.DataTypes;

public class NullableTypes
{
    public static void Print()
    {
        System.Console.WriteLine("## Nullable Types ##");

        // int value = null; // error: 'int' type is non-nullable
        // default value for 'int' is 0

        // Nullable<int> nl = null; // it can be simplified
        // int? nl = null;
        // double? nl2 = null;
        // bool? nl3 = null;

        // nullable types cannot be assigned to non-nullable types
        int? a = null;
        // int b = a; // error 
        // use the operator '??' instead
        int b = a ?? 0; // coalesce

        // // in expressions use the same type for all variables 
        // int? x = 4;
        // // int y = 3; // error
        // int? y = 3;
        // int? z = x * y;

        // System.Console.WriteLine($"a: {a}\nb: {b}");
        // System.Console.WriteLine($"x: {x}\ny: {y}\nz: {z}");

        /* In Python is like:

        x: int = None

        if x is not None:
            print(f"x = {x}")
        else:
            print("x is None")
        */
        int? x = null;

        if (x.HasValue)
        {
            System.Console.WriteLine($"x = {x.Value}");
        }
        else
        {
            System.Console.WriteLine("x is null");
        }


        // System.Console.WriteLine(nl); // null types not show in console
        // System.Console.WriteLine(nl2);
        // System.Console.WriteLine(nl3);
    }
}