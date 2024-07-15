using FluentAssertions;

namespace Evercraft;

public class CharacterTests
{
    const string CHARACTER_NAME = "Bob";

    readonly Character TestCharacter;

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
    void CharacterHasAnAlignment()
    {
        TestCharacter.Alignment.Should().NotBeNull();
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

    [Fact]
    void CharacterHasADefaultArmorClassOf10()
    {
        TestCharacter.ArmorClass.Should().Be(10);
    }

    [Fact]
    void CharacterHasADefaultHitPointsOf5()
    {
        TestCharacter.Hitpoints.Should().Be(5);
    }
}