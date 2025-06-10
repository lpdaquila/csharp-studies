namespace CSharpConsoleStudies.DataTypes;

public class DateAndTime
{
    public static void Print()
    {
        System.Console.WriteLine("## Struct DateTime ##\n");

        DateTime actual = DateTime.Now;

        System.Console.WriteLine($"Today: {actual}");

        // System.Console.WriteLine(actual.Year);
        // System.Console.WriteLine(actual.Month);
        // System.Console.WriteLine(actual.Day);
        // System.Console.WriteLine(actual.Hour);
        // System.Console.WriteLine(actual.Minute);
        // System.Console.WriteLine(actual.Second);
        // System.Console.WriteLine(actual.Millisecond);

        // adding values

        System.Console.WriteLine(actual.AddDays(30));
        System.Console.WriteLine(actual.AddMonths(3));
        System.Console.WriteLine(actual.AddHours(8));
        System.Console.WriteLine(actual.AddYears(5));

        // get the day of week and year

        System.Console.WriteLine(actual.DayOfWeek);
        System.Console.WriteLine(actual.DayOfYear);

        System.Console.WriteLine(actual.ToLongDateString());
        System.Console.WriteLine(actual.ToShortDateString());

        System.Console.WriteLine(actual.ToLongTimeString());
        System.Console.WriteLine(actual.ToShortTimeString());


        // // create an especific date

        // DateTime dateh = new(2025, 09, 12);

        // // with hours

        // DateTime datehr = new(2025, 09, 12, 07, 15, 46);

        // System.Console.WriteLine(dateh);
        // System.Console.WriteLine(datehr);

        Console.ReadKey();
    }
}