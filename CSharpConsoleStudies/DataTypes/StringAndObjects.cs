namespace CSharpConsoleStudies.DataTypes;

public class StringAndObjects
{
    public static void Print()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("## Strings, Objects and Dynamic types ##");

        string name = "Hello Essential Csharp"; // like in python, this type is immutable 

        // name = "This is a new string"; // This value will be placed in another memory address 
        /*
        Do not use string type if you need to modify your text
        All modifications will be placed in another memory address 
        Growing the memory usage
        */

        // use StringBuilder instead

        System.Console.WriteLine(name);

        // objects can be anything 

        // 'dynamic' is the same of the 'object'
        // use 'dynamic' when you need to use some advanced resource as "Reflection" for example
        dynamic note = 10; // int 
        dynamic value = 8.55m; // double
        object name1 = "Csharp Course"; // string
        object ok = true; // bool
        object letter = 'A'; // char

        System.Console.WriteLine(note);
        System.Console.WriteLine(value);
        System.Console.WriteLine(name1);
        System.Console.WriteLine(ok);
        System.Console.WriteLine(letter);
    }
}