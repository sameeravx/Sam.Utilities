using Sam.Utilities.StringKit.Extensions;

namespace Sam.Utilities.StringKit.Tests.Extensions;

public class StringCleaningExtensionsTests
{
    #region RemoveWhiteSpaces Tests
    [Fact]
    public void RemoveWhiteSpaces_ReturnsStringWithoutSpaces_WhenStringContainsSpaces_Positive()
    {
        // Arrange
        string value = "Hello World";

        // Act
        string result = value.RemoveWhiteSpaces();

        // Assert
        Assert.Equal("HelloWorld", result);
    }

    [Fact]
    public void RemoveWhiteSpaces_ReturnsStringWithoutWhiteSpaces_WhenStringContainsTabsAndNewLines_Positive()
    {
        // Arrange
        string value = "Hello\tWorld\nTest";

        // Act
        string result = value.RemoveWhiteSpaces();

        // Assert
        Assert.Equal("HelloWorldTest", result);
    }

    [Fact]
    public void RemoveWhiteSpaces_ReturnsEmptyString_WhenStringIsNull_Negative()
    {
        // Arrange
        string? value = null;

        // Act
        string result = value.RemoveWhiteSpaces();

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void RemoveWhiteSpaces_ReturnsEmptyString_WhenStringIsEmpty_Negative()
    {
        // Arrange
        string value = string.Empty;

        // Act
        string result = value.RemoveWhiteSpaces();

        // Assert
        Assert.Equal(string.Empty, result);
    }
    #endregion RemoveWhiteSpaces Tests

    #region NormalizeSpaces Tests
    [Fact]
    public void NormalizeSpaces_ReturnsNormalizedString_WhenStringContainsMultipleSpaces_Positive()
    {
        // Arrange
        string value = "Hello    World";

        // Act
        string result = value.NormalizeSpaces();

        // Assert
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void NormalizeSpaces_ReturnsNormalizedString_WhenStringContainsTabsAndNewLines_Positive()
    {
        // Arrange
        string value = "Hello\tWorld\nTest";

        // Act
        string result = value.NormalizeSpaces();

        // Assert
        Assert.Equal("Hello World Test", result);
    }

    [Fact]
    public void NormalizeSpaces_ReturnsEmptyString_WhenStringIsEmpty_Negative()
    {
        // Arrange
        string value = string.Empty;

        // Act
        string result = value.NormalizeSpaces();

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void NormalizeSpaces_ReturnsEmptyString_WhenStringIsNull_Negative()
    {
        // Arrange
        string? value = null;

        // Act
        string result = value.NormalizeSpaces();

        // Assert
        Assert.Equal(string.Empty, result);
    }
    #endregion NormalizeSpaces Tests
}