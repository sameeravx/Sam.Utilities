namespace Sam.Utilities.StringKit.Helpers;

internal static class StringValidationHelper
{
    internal static bool Validate(string? value, Func<char, bool> predicate)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        return value.All(predicate);
    }
}