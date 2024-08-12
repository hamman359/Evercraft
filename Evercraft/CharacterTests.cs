using Evercraft.Domain;

namespace Evercraft.Tests;

public class CharacterTests
{
    const string CharacterName = "Bob";

    [Fact]
    void Character_Should_HaveAName()
    {
        Character character = new(CharacterName);

        character.Name.Should().Be(CharacterName);
    }
}
