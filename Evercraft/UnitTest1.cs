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
    void CanAssignACharacterAnAlignment()
    {
        TestCharacter.AssignAlignment("Good");

        TestCharacter.Alignment.Should().Be("Good");
    }
}