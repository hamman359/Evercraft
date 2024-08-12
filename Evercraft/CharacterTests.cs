using Evercraft.Domain;

namespace Evercraft.Tests;

public class CharacterTests
{
    const string CharacterName = "Bob";
    readonly Character _character;

    public CharacterTests()
    {
        _character = Character.Create()
            .SetName(CharacterName);
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

    [Fact]
    void Character_Should_HaveAnAlignment()
    {
        _character.Alignment.Should().NotBeNull();
    }

    [Fact]
    void Character_Should_BeAbleToHaveAGoodAlignment()
    {
        _character.SetAlignment(Alignment.Good);

        _character.Alignment.Should().Be(Alignment.Good);
    }

    [Fact]
    void Character_Should_BeAbleToHaveANeutralAlignment()
    {
        _character.SetAlignment(Alignment.Neutral);

        _character.Alignment.Should().Be(Alignment.Neutral);
    }

    [Fact]
    void Character_Should_BeAbleToHaveAEvilAlignment()
    {
        _character.SetAlignment(Alignment.Evil);

        _character.Alignment.Should().Be(Alignment.Evil);
    }

    [Fact]
    void Character_Should_HaveADefaultArmorClassOf10()
    {
        _character.ArmorClass.Should().Be(10);
    }

    [Fact]
    void Character_Should_HaveADefaultHitPointsOf5()
    {
        _character.HitPoints.Should().Be(5);
    }
}