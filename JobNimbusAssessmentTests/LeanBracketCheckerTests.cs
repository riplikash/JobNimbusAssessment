using FluentAssertions;

namespace JobNimbusAssessmentTests;

public class StackBracketCheckerTest
{
    IBracketChecker sut = new StackBracketChecker();

    [Theory]
    [InlineData("<>")]
    [InlineData("<Spot>")]
    [InlineData("See <Spot> run")]
    [InlineData("<Run> spot <run>")]
    public void CheckBrackets_MatchingBrackets_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("No brackets here, dude")]
    public void CheckBrackets_NoBrackets_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("<<>>")]
    [InlineData("<Doing <stuff>>")]
    [InlineData("See <<<Spot>>> run")]
    [InlineData("<<Run> spot <run>>")]
    public void CheckBrackets_NestedBrackets_ReturnTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("<")]
    [InlineData(">")]
    [InlineData("<Run spot <run")]
    [InlineData("do the thing>")]
    public void CheckBrackets_NoMatchingBracket_ReturnsFalse(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("><")]
    [InlineData(">><<")]
    [InlineData("<>>")]
    [InlineData("<Run> spot >run<")]
    public void CheckBrackets_InvertedBrackets_ReturnsFalse(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("<><")]
    [InlineData("<Run> spot <run<")]
    [InlineData("<do <the thing>")]
    public void CheckBrackets_MixedResults_ReturnsFalse(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("   ")]
    [InlineData(null)]
    public void CheckBrackets_EmptyString_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("<>({[")]
    [InlineData("]})")]
    [InlineData("<Mixed> (sentence} [ ")]
    public void CheckBrackets_OtherFormsOfBracketsNotSetCorrecctly_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }
}

public class LeanBracketCheckerTests
{
    IBracketChecker sut = new LeanBracketChecker();

    [Theory]
    [InlineData("<>")]
    [InlineData("<Spot>")]
    [InlineData("See <Spot> run")]
    [InlineData("<Run> spot <run>")]
    public void CheckBrackets_MatchingBrackets_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("No brackets here, dude")]
    public void CheckBrackets_NoBrackets_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("<<>>")]
    [InlineData("<Doing <stuff>>")]
    [InlineData("See <<<Spot>>> run")]
    [InlineData("<<Run> spot <run>>")]
    public void CheckBrackets_NestedBrackets_ReturnTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("<")]
    [InlineData(">")]
    [InlineData("<Run spot <run")]
    [InlineData("do the thing>")]
    public void CheckBrackets_NoMatchingBracket_ReturnsFalse(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("><")]
    [InlineData(">><<")]
    [InlineData("<>>")]
    [InlineData("<Run> spot >run<")]
    public void CheckBrackets_InvertedBrackets_ReturnsFalse(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("<><")]
    [InlineData("<Run> spot <run<")]
    [InlineData("<do <the thing>")]
    public void CheckBrackets_MixedResults_ReturnsFalse(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("   ")]
    [InlineData(null)]
    public void CheckBrackets_EmptyString_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("<>({[")]
    [InlineData("]})")]
    [InlineData("<Mixed> (sentence} [ ")]
    public void CheckBrackets_OtherFormsOfBracketsNotSetCorrecctly_ReturnsTrue(string input)
    {
        // Arrange

        // Act
        bool result = sut.CheckBracket(input);

        // Assert
        result.Should().BeTrue();
    }
}