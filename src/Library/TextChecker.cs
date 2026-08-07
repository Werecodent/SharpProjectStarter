using System.Text.RegularExpressions;

namespace Werecodent.UltimateProjectStarter.Library;

/// <summary>Verifies string contents.</summary>
public static partial class TextChecker
{
    [GeneratedRegex(@"^[\w\d]+$", RegexOptions.CultureInvariant, matchTimeoutMilliseconds: 1000)]
    private static partial Regex NumbersAndLettersRegex { get; }

    /// <summary>Verifies input only has numbers and letters.</summary>
    /// <param name="input">String to check.</param>
    /// <returns>True if valid; false otherwise.</returns>
    public static bool IsOnlyNumbersAndLetters(string input)
    {
        return NumbersAndLettersRegex.IsMatch(input);
    }
}
