using FluentAssertions;

namespace Evercraft;

public class CharacterTests
{
    const string CHARACTER_NAME = "Bob";

    [Fact]
    public void CanCreateACharacterWithAName()
    {
        var character = new Character(CHARACTER_NAME);

        character.Name.Should().Be(CHARACTER_NAME);
    }

    [Fact]
    void CanChangeACharactersName()
    {
        var character = new Character(CHARACTER_NAME);

        const string NEW_NAME = "Kevin";

        character.ChangeName(NEW_NAME);

        character.Name.Should().Be(NEW_NAME);
    }
}