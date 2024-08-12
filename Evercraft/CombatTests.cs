using Evercraft.Domain;

namespace Evercraft.Tests;
public class CombatTests
{
    readonly Character _attacker;
    readonly Character _opponent;

    public CombatTests()
    {
        _attacker = Character.Create();
        _opponent = Character.Create();
    }

    [Fact]
    void CharacterAtack_Should_BeHitWhenBeetsOpponentsAC()
    {
        var result = _attacker.Attack(_opponent, Roll.Create(11));

        result.IsHit.Should().BeTrue();
        result.IsMiss.Should().BeFalse();
    }

    [Fact]
    void CharacterAtack_Should_BeHitWhenMeetsOpponentsAC()
    {
        var result = _attacker.Attack(_opponent, Roll.Create(10));

        result.IsHit.Should().BeTrue();
        result.IsMiss.Should().BeFalse();
    }

    [Fact]
    void CharacterAtack_Should_BeMissWhenDoesNotMeetOrBeetOpponentsAC()
    {
        var result = _attacker.Attack(_opponent, Roll.Create(9));

        result.IsMiss.Should().BeTrue();
        result.IsHit.Should().BeFalse();
    }
}
