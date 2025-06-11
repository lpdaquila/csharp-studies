namespace CSharpConsoleStudies.DataInputOutput;

class TypeInference
{
    public static void TypeInfer()
    {
        // use 'var' to infer types to a variable

        // Implicit
        // int i = 25;
        // string n = "test";
        // double wage = 2500.00;

        // Type infer
        // 'var' is a sugarsyntax of C#
        var i = 25;
        var n = "Test";
        var wage = 2500.00;

        // With type inference you can't do this things:
        // var test = null; // cannot assign a null
        // var x; // must assign some value
        // var invoice, test; // cannot assign multiple variables 

        System.Console.WriteLine($"Name: {n} age: {i} wage: {wage:c}");

        var test = new Test(); // user types can be used with 'var'
        test.MyMethod();
    }
    class Test
    {
        public void MyMethod()
        {
            System.Console.WriteLine("My test method");
        }
    }
}