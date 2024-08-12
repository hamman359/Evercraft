using Evercraft.Domain;

namespace Evercraft.Tests;

public class CharacterTests
{
    const string CharacterName = "Bob";
    readonly Character _character;

    public CharacterTests()
    {
        _character = new Character();

        _character.SetName(CharacterName);
    }

    [Fact]
    void Character_Should_HaveAName()
    {

        _character.Name.Should().Be(CharacterName);
    }


    [Fact]
    void Character_Should_BeAbleToChangeNames()
    {
        var newName = "Kevin";

        _character.SetName(newName);

        _character.Name.Should().Be(newName);
    }
}
