using Werecodent.SharpProjectStarter.Library;

namespace Werecodent.SharpProjectStarter.Terminal;

/// <summary>Handles running chess on the console.</summary>
internal static class Program
{
    /// <summary>Application entry point.</summary>
    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? "quit";
            if (TextChecker.IsOnlyNumbersAndLetters(input))
            {
                switch (input)
                {
                    default:
                        Console.WriteLine(input);
                        break;
                    case "quit":
                    case "q":
                        return;
                }
            }
        }
    }
}
