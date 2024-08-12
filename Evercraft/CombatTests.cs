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

    [Fact]
    void Character_Should_BeDamagedWhenEnemyAttackHits()
    {
        var originalHP = _opponent.HitPoints;

        _opponent.ApplyDamage(AttackResult.Hit());

        _opponent.HitPoints.Value.Should().BeLessThan(originalHP.Value);
    }

    [Fact]
    void Character_Should_NotBeDamagedWhenEnemyAttackMisses()
    {
        var originalHP = _opponent.HitPoints;

        _opponent.ApplyDamage(AttackResult.Miss());

        _opponent.HitPoints.Should().Be(originalHP);
    }

    [Fact]
    void Character_Should_TakeDoubleDamagedWhenEnemyAttackCriticalHits()
    {
        var originalHP = _opponent.HitPoints;

        _opponent.ApplyDamage(AttackResult.CriticalHit());

        _opponent.HitPoints.Value.Should().Be(originalHP.Value - 2);
    }
}
