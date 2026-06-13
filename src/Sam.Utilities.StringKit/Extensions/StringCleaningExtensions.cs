namespace Sam.Utilities.StringKit.Extensions;

/// <summary>
/// Provides extension methods for cleaning string values.
/// </summary>
public static class StringCleaningExtensions
{
    /// <summary>
    /// Removes all whitespace characters from a string.
    /// </summary>
    public static string RemoveWhiteSpaces(this string? value)
    {
        if (string.IsNullOrEmpty(value))
            return string.Empty;

        return new string(value.Where(c => !char.IsWhiteSpace(c)).ToArray());
    }

    /// <summary>
    /// Replaces multiple whitespace characters with a single space
    /// and trims the result.
    /// </summary>
    public static string NormalizeSpaces(this string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;

        return System.Text.RegularExpressions.Regex.Replace(value.Trim(), @"\s+", " ");
    }
}