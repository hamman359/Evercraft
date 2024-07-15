using FluentAssertions;

namespace Evercraft;

public class CombatTests
{
    Character _attacher;
    Character _defender;

    public CombatTests()
    {
        _attacher = new Character("Attacker");
        _defender = new Character("Defender");
    }

    [Fact]
    void CharacterCanAttack()
    {
        var result = _attacher.Attack(10, _defender);

        result.Should().NotBeNull();
    }

    [Fact]
    void AttackRollThatBeatsDefendersACIsAHit()
    {
        var result = _attacher.Attack(15, _defender);

        result.IsHit.Should().Be(true);
        result.IsMiss.Should().Be(false);
    }

    [Fact]
    void AttackRollThatMatchesDefendersACIsAHit()
    {
        var result = _attacher.Attack(10, _defender);

        result.IsHit.Should().Be(true);
        result.IsMiss.Should().Be(false);
    }

    [Fact]
    void AttackRollThatDoesNotBeatDefendersACIsAMiss()
    {
        var result = _attacher.Attack(5, _defender);

        result.IsMiss.Should().Be(true);
        result.IsHit.Should().Be(false);
    }
}
