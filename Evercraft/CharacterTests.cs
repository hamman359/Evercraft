using Evercraft.Domain;

namespace Evercraft.Tests;

public class CharacterTests
{
    const string CharacterName = "Bob";

    [Fact]
    void Character_Should_HaveAName()
    {
        Character character = new();

        character.SetName(CharacterName);

        character.Name.Should().Be(CharacterName);
    }

    [Fact]
    void Character_Should_BeAbleToChangeNames()
    {
        Character character = new();

        character.SetName(CharacterName);

        var newName = "Kevin";

        character.SetName(newName);

        character.Name.Should().Be(newName);
    }
}
