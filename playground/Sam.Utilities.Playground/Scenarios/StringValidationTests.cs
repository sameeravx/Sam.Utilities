using Sam.Utilities.StringKit.Extensions;

namespace Sam.Utilities.Playground.Scenarios;

public static class StringValidationTests
{
    public static void Run()
    {
        Console.WriteLine("Hello".IsLettersOnly());
        Console.WriteLine("Hello123".IsLettersOnly());
        Console.WriteLine("".IsLettersOnly());
    }
}