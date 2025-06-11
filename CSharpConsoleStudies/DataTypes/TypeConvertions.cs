using System.Runtime.ConstrainedExecution;

namespace CSharpConsoleStudies.DataTypes;

public class TypeConvertions
{
    public static void PrintImplicit()
    {
        System.Console.WriteLine("## Type Convertions ##");

        // implict convertion

        int varInt = 100; // 4 bytes
        double varDouble = varInt; // 8 bytes
                                   // You can only convert types to another type with more bytes than himself
                                   // For example: int (4 bytes) to double (8 bytes)

        int numInt = 123123;
        long numLong = numInt;
        float numFloat = numInt;
        double numDouble = numInt;
        decimal numDecimal = numInt;

        System.Console.WriteLine(numInt);
        System.Console.WriteLine(numLong);
        System.Console.WriteLine(numFloat);
        System.Console.WriteLine(numDouble);
        System.Console.WriteLine(numDecimal);


        System.Console.WriteLine(varDouble);
    }

    public static void PrintCast()
    {
        System.Console.WriteLine("## Type Convertions ##");

        double varDouble = 12.455; // 8-bytes
        int varInt = (int)varDouble; // explicit cast

        System.Console.WriteLine(varInt);

        int num1 = 10;
        int num2 = 4;

        float result = (float)num1 / num2; // 10/4 = 2.5 | without cast the result will be 2

        System.Console.WriteLine(result);
    }

    public static void PrintToString()
    {
        int valueInt = 123000;
        double valueDouble = 12.45;
        decimal valueDecimal = 12.34565m;

        string s1 = valueInt.ToString();
        string s2 = valueDouble.ToString();
        string s3 = valueDecimal.ToString();

        System.Console.WriteLine(s1);
        System.Console.WriteLine(s2);
        System.Console.WriteLine(s3);

        // System.Console.WriteLine(Convert.ToByte(valueInt)); // overflow exception, too long for an unsigned byte

        // using the class Convert from namespace "System"
        // ToBoolean()
        // ToChar()
        // ToDouble()
        // ToInt16()
        // ToInt32()
        // ToString()

    }
}