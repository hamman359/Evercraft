using FluentAssertions;

namespace Evercraft;

public class CharacterTests
{
    const string CHARACTER_NAME = "Bob";

    Character TestCharacter;

    public CharacterTests() =>
        TestCharacter = new Character(CHARACTER_NAME);

    [Fact]
    public void CanCreateACharacterWithAName()
    {
        TestCharacter.Name.Should().Be(CHARACTER_NAME);
    }

    [Fact]
    void CanChangeACharactersName()
    {
        const string NEW_NAME = "Kevin";

        TestCharacter.ChangeName(NEW_NAME);

        TestCharacter.Name.Should().Be(NEW_NAME);
    }

    [Fact]
    void CanAssignCharacterAnAlignmentOfGood()
    {
        TestCharacter.AssignGoodAlignment();

        TestCharacter.Alignment.Should().Be(Alignment.Good);
    }

    [Fact]
    void CanAssignCharacterAnAlignmentOfEvil()
    {
        TestCharacter.AssignEvilAlignment();

        TestCharacter.Alignment.Should().Be(Alignment.Evil);
    }

    [Fact]
    void CanAssignCharacterAnAlignmentOfNeutral()
    {
        TestCharacter.AssignNeutralAlignment();

        TestCharacter.Alignment.Should().Be(Alignment.Neutral);
    }
}