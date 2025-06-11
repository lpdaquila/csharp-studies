namespace CSharpConsoleStudies.DataInputOutput;

public class DataInputs
{
    public static void Inputs()
    {
        Console.WriteLine("what is your name? ");
        string name = Console.ReadLine();

        System.Console.WriteLine("what is your age ?");
        int age = Convert.ToInt32(Console.ReadLine());
        // int age = Console.Read(); // it will return the ASCII number of first typed char or number

        Console.WriteLine($"your name is {name}");
        System.Console.WriteLine($"your age is {age}");

    }
}