using Sam.Utilities.StringKit.Extensions;

namespace Sam.Utilities.StringKit.Tests.Extensions;

public class StringFormattingExtensionsTests
{
    [Fact]
    public void ToTitleCase_ReturnsTitleCase_WhenStringIsLowerCase_Positive()
    {
        // Arrange
        string value = "hello world";

        // Act
        string result = value.ToTitleCase();

        // Assert
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void ToTitleCase_ReturnsTitleCase_WhenStringIsUpperCase_Positive()
    {
        // Arrange
        string value = "HELLO WORLD";

        // Act
        string result = value.ToTitleCase();

        // Assert
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void ToTitleCase_ReturnsEmptyString_WhenStringIsEmpty_Negative()
    {
        // Arrange
        string value = string.Empty;

        // Act
        string result = value.ToTitleCase();

        // Assert
        Assert.Equal(string.Empty, result);
    }
}