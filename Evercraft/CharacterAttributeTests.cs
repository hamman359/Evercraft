namespace Evercraft.Tests;

public class CharacterAttributeTests
{
    [Theory]
    [InlineData(1, -5)]
    [InlineData(2, -4)]
    [InlineData(3, -4)]
    [InlineData(4, -3)]
    [InlineData(5, -3)]
    [InlineData(6, -2)]
    [InlineData(7, -2)]
    [InlineData(8, -1)]
    [InlineData(9, -1)]
    [InlineData(10, 0)]
    [InlineData(11, 0)]
    [InlineData(12, 1)]
    [InlineData(13, 1)]
    [InlineData(14, 2)]
    [InlineData(15, 2)]
    [InlineData(16, 3)]
    [InlineData(17, 3)]
    [InlineData(18, 4)]
    [InlineData(19, 4)]
    [InlineData(20, 5)]
    void CharacterAttributes_Should_HaveCorrectModifiers(
       int value,
       int modifier)
    {
        StrengthCharacterAttribute.Create(value).Modifier.Should().Be(modifier);
    }

    [Fact]
    void CharacterAttributes_ShouldNot_BeAbleToBeBelowOne()
    {
        Action act = () => StrengthCharacterAttribute.Create(0);

        act.Should().Throw<ArgumentOutOfRangeException>();
    }


    [Fact]
    void CharacterAttributes_ShouldNot_BeAbleToBeAbove20()
    {
        Action act = () => StrengthCharacterAttribute.Create(21);

        act.Should().Throw<ArgumentOutOfRangeException>();
    }
}
