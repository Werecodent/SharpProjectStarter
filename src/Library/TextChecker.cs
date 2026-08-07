namespace Werecodent.UltimateProjectStarter.Library;

/// <summary>Verifies string contents.</summary>
public static class TextChecker
{
    /// <summary>Verifies input only has numbers and letters.</summary>
    /// <param name="input">String to check.</param>
    /// <returns>True if valid; false otherwise.</returns>
    public static bool IsOnlyNumbersAndLetters(string input)
    {
        return input.All(char.IsLetterOrDigit);
    }
}
