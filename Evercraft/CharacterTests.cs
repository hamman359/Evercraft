namespace Evercraft;

public class CharacterTests
{
    const string CHARACTER_NAME = "Bob";

    readonly Character _character;

    public CharacterTests() =>
        _character = new Character(CHARACTER_NAME);

    [Fact]
    public void CanCreateACharacterWithAName()
    {
        _character.Name.Should().Be(CHARACTER_NAME);
    }

    [Fact]
    void CanChangeACharactersName()
    {
        const string NEW_NAME = "Kevin";

        _character.ChangeName(NEW_NAME);

        _character.Name.Should().Be(NEW_NAME);
    }

    [Fact]
    void CharacterHasAnAlignment()
    {
        _character.Alignment.Should().NotBeNull();
    }

    [Fact]
    void CanAssignCharacterAnAlignmentOfGood()
    {
        _character.AssignGoodAlignment();

        _character.Alignment.Should().Be(Alignment.Good);
    }

    [Fact]
    void CanAssignCharacterAnAlignmentOfEvil()
    {
        _character.AssignEvilAlignment();

        _character.Alignment.Should().Be(Alignment.Evil);
    }

    [Fact]
    void CanAssignCharacterAnAlignmentOfNeutral()
    {
        _character.AssignNeutralAlignment();

        _character.Alignment.Should().Be(Alignment.Neutral);
    }

    [Fact]
    void CharacterHasADefaultArmorClassOf10()
    {
        _character.ArmorClass.Should().Be(10);
    }

    [Fact]
    void CharacterHasADefaultHitPointsOf5()
    {
        _character.HitPoints.Should().Be(5);
    }
}