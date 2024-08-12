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
        _character.ArmorClass.Value.Should().Be(10);
    }

    [Fact]
    void Character_Should_HaveADefaultHitPointsOf5()
    {
        _character.HitPoints.MaxHP.Should().Be(5);
    }

    [Fact]
    void Character_Should_HaveADefaultStrenghtOf10()
    {
        _character.Strength.Value.Should().Be(10);
    }

    [Fact]
    void Character_Should_HaveADefaultDexterityOf10()
    {
        _character.Dexterity.Value.Should().Be(10);
    }

    [Fact]
    void Character_Should_HaveADefaultConstitutionOf10()
    {
        _character.Constitution.Value.Should().Be(10);
    }

    [Fact]
    void Character_Should_HaveADefaultWisdomOf10()
    {
        _character.Wisdom.Value.Should().Be(10);
    }

    [Fact]
    void Character_Should_HaveADefaultIntelligenceOf10()
    {
        _character.Intelligence.Value.Should().Be(10);
    }

    [Fact]
    void Character_Should_HaveADefaultCharismaOf10()
    {
        _character.Charisma.Value.Should().Be(10);
    }

    [Fact]
    void Character_Should_BeAbleToUpdateStrenght()
    {
        _character.SetStrength(15);
        _character.Strength.Value.Should().Be(15);
    }

    [Fact]
    void Character_Should_BeAbleToUpdateDexterity()
    {
        _character.SetDexterity(15);
        _character.Dexterity.Value.Should().Be(15);
    }

    [Fact]
    void Character_Should_BeAbleToUpdateConstitution()
    {
        _character.SetConstitution(15);
        _character.Constitution.Value.Should().Be(15);
    }

    [Fact]
    void Character_Should_BeAbleToUpdateWisdom()
    {
        _character.SetWisdom(15);
        _character.Wisdom.Value.Should().Be(15);
    }

    [Fact]
    void Character_Should_BeAbleToUpdateIntelligence()
    {
        _character.SetIntelligence(15);
        _character.Intelligence.Value.Should().Be(15);
    }

    [Fact]
    void Character_Should_BeAbleToUpdateCharisma()
    {
        _character.SetCharisma(15);
        _character.Charisma.Value.Should().Be(15);
    }

}