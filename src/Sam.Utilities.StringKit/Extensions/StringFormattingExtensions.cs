namespace Sam.Utilities.StringKit.Extensions;

/// <summary>
/// Provides extension methods for string values.
/// </summary>
public static class StringFormattingExtensions
{
    /// <summary>
    /// Converts a string to title case.
    /// </summary>
    public static string ToTitleCase(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return value;

        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
    }
}