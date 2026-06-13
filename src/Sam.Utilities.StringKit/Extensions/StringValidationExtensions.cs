using Sam.Utilities.StringKit.Helpers;

namespace Sam.Utilities.StringKit.Extensions;

/// <summary>
/// Provides extension methods for validating string content.
/// </summary>
public static class StringValidationExtensions
{
    /// <summary>
    /// Checks whether a string contains only letters.
    /// </summary>
    public static bool IsLettersOnly(this string? value)
    {
        return StringValidationHelper.Validate(value, char.IsLetter);
    }

    /// <summary>
    /// Checks whether a string contains only numeric digits.
    /// </summary>
    public static bool IsNumericOnly(this string? value)
    {
        return StringValidationHelper.Validate(value, char.IsDigit);
    }

    /// <summary>
    /// Checks whether a string contains only letters and numbers.
    /// </summary>
    public static bool IsAlphaNumeric(this string? value)
    {
        return StringValidationHelper.Validate(value, char.IsLetterOrDigit);
    }
}

