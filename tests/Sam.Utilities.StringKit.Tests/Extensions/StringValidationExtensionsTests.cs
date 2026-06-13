using Sam.Utilities.StringKit.Extensions;

namespace Sam.Utilities.StringKit.Tests.Extensions;

public class StringValidationExtensionsTests
{
    #region IsLettersOnly Tests
    [Fact]
    public void IsLettersOnly_ReturnsTrue_WhenStringContainsOnlyLetters_Positive()
    {
        // Arrange
        string value = "HelloWorld";

        // Act
        bool result = value.IsLettersOnly();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsLettersOnly_ReturnsFalse_WhenStringContainsNumbers_Negative()
    {
        // Arrange
        string value = "Hello123";

        // Act
        bool result = value.IsLettersOnly();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsLettersOnly_ReturnsFalse_WhenStringIsEmpty_Negative()
    {
        // Arrange
        string value = string.Empty;

        // Act
        bool result = value.IsLettersOnly();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsLettersOnly_ReturnsFalse_WhenStringIsNull_Negative()
    {
        // Arrange
        string? value = null;

        // Act
        bool result = value.IsLettersOnly();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsLettersOnly_ReturnsFalse_WhenStringContainsWhiteSpace_Negative()
    {
        // Arrange
        string value = "Hello World";

        // Act
        bool result = value.IsLettersOnly();

        // Assert
        Assert.False(result);
    }
    #endregion IsLettersOnly Tests

    #region IsNumericOnly Tests
    [Theory]
    [InlineData("123456")]
    [InlineData("999")]
    [InlineData("0")]
    public void IsNumericOnly_ReturnsTrue_WhenStringContainsOnlyNumbers_Positive(string value)
    {
        // Arrange

        // Act
        bool result = value.IsNumericOnly();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNumericOnly_ReturnsFalse_WhenStringContainsLetters_Negative()
    {
        // Arrange
        string value = "123ABC";

        // Act
        bool result = value.IsNumericOnly();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumericOnly_ReturnsFalse_WhenStringIsNull_Negative()
    {
        // Arrange
        string? value = null;

        // Act
        bool result = value.IsNumericOnly();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumericOnly_ReturnsFalse_WhenStringIsEmpty_Negative()
    {
        // Arrange
        string value = string.Empty;

        // Act
        bool result = value.IsNumericOnly();

        // Assert
        Assert.False(result);
    }
    #endregion IsNumericOnly Tests

    #region IsAlphaNumeric Tests
    [Fact]
    public void IsAlphaNumeric_ReturnsTrue_WhenStringContainsOnlyLettersAndNumbers_Positive()
    {
        // Arrange
        string value = "Hello123";

        // Act
        bool result = value.IsAlphaNumeric();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsAlphaNumeric_ReturnsFalse_WhenStringContainsSpecialCharacters_Negative()
    {
        // Arrange
        string value = "Hello@123";

        // Act
        bool result = value.IsAlphaNumeric();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsAlphaNumeric_ReturnsFalse_WhenStringIsNull_Negative()
    {
        // Arrange
        string? value = null;

        // Act
        bool result = value.IsAlphaNumeric();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsAlphaNumeric_ReturnsFalse_WhenStringIsEmpty_Negative()
    {
        // Arrange
        string value = string.Empty;

        // Act
        bool result = value.IsAlphaNumeric();

        // Assert
        Assert.False(result);
    }
    #endregion IsAlphaNumeric Tests
}