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

    [Fact]
    void CharacterIsAlive()
    {
        _character.IsAlive.Should().Be(true);
    }

    [Fact]
    void CharacterIsDeadWhenHitPointsAreZero()
    {
        while(_character.HitPoints > 0)
        {
            _character.TakeDamage(AttackResult.Hit());
        }

        _character.IsAlive.Should().Be(false);
    }

    [Fact]
    void CharacterIsDeadWhenHitPointsAreBelowZero()
    {
        while(_character.HitPoints >= 0)
        {
            _character.TakeDamage(AttackResult.CriticalHit());
        }

        _character.IsAlive.Should().Be(false);
    }

    [Fact]
    void CharacterHasADefaultStrengthOf10()
    {
        _character.Strength.Value.Should().Be(10);
    }

    [Fact]
    void CharacterHasADefaultDexterityOf10()
    {
        _character.Dexterity.Value.Should().Be(10);
    }

    [Fact]
    void CharacterHasADefaultConstitutionOf10()
    {
        _character.Constitution.Value.Should().Be(10);
    }

    [Fact]
    void CharacterHasADefaultIntelligenceOf10()
    {
        _character.Intelligence.Value.Should().Be(10);
    }

    [Fact]
    void CharacterHasADefaultWisdomOf10()
    {
        _character.Wisdom.Value.Should().Be(10);
    }

    [Fact]
    void CharacterHasADefaultCharismaOf10()
    {
        _character.Charisma.Value.Should().Be(10);
    }

    [Fact]
    void CharacterStrangthMustBeBetween1And20()
    {
        Action act = () => _character.SetStrength(0);
        act.Should().Throw<ArgumentOutOfRangeException>();

        act = () => _character.SetStrength(21);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }


    [Fact]
    void CharacterDexterityMustBeBetween1And20()
    {
        Action act = () => _character.SetDexterity(0);
        act.Should().Throw<ArgumentOutOfRangeException>();

        act = () => _character.SetDexterity(21);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    void CharacterConstitutionMustBeBetween1And20()
    {
        Action act = () => _character.SetConstitution(0);
        act.Should().Throw<ArgumentOutOfRangeException>();

        act = () => _character.SetConstitution(21);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    void CharacterWisdomMustBeBetween1And20()
    {
        Action act = () => _character.SetWisdom(0);
        act.Should().Throw<ArgumentOutOfRangeException>();

        act = () => _character.SetWisdom(21);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    void CharacterIntelligenceMustBeBetween1And20()
    {
        Action act = () => _character.SetIntelligence(0);
        act.Should().Throw<ArgumentOutOfRangeException>();

        act = () => _character.SetIntelligence(21);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    void CharacterCharismaMustBeBetween1And20()
    {
        Action act = () => _character.SetCharisma(0);
        act.Should().Throw<ArgumentOutOfRangeException>();

        act = () => _character.SetCharisma(21);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
}