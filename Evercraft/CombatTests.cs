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

        _opponent.ApplyDamage(AttackResult.Create(Roll.Create(15), _opponent, new()));

        _opponent.HitPoints.CurrentHP.Should().BeLessThan(originalHP.MaxHP);
    }

    [Fact]
    void Character_ShouldNot_BeDamagedWhenEnemyAttackMisses()
    {
        var originalHP = _opponent.HitPoints;

        _opponent.ApplyDamage(AttackResult.Create(Roll.Create(5), _opponent, new()));

        _opponent.HitPoints.Should().Be(originalHP);
    }

    [Fact]
    void Character_Should_TakeDoubleDamagedWhenEnemyAttackCriticalHits()
    {
        var originalHP = _opponent.HitPoints;

        _opponent.ApplyDamage(AttackResult.Create(Roll.Create(20), _opponent, new()));

        _opponent.HitPoints.CurrentHP.Should().Be(originalHP.MaxHP - 2);
    }

    [Fact]
    void Character_Should_BeAliveIfHPIsAboveZero()
    {
        _attacker.HitPoints.CurrentHP.Should().BeGreaterThan(0);
        _attacker.IsAlive.Should().BeTrue();
    }

    [Fact]
    void Character_ShouldNot_BeAliveIfHPIsZero()
    {
        do
        {
            _opponent.ApplyDamage(AttackResult.Create(Roll.Create(15), _opponent, new()));
        }
        while(_opponent.HitPoints.CurrentHP != 0);

        _opponent.IsAlive.Should().BeFalse();
    }

    [Fact]
    void Character_Should_NotBeAliveIfHPBelowZero()
    {
        do
        {
            _opponent.ApplyDamage(AttackResult.Create(Roll.Create(20), _opponent, new()));
        }
        while(_opponent.HitPoints.CurrentHP > 0);

        _opponent.IsAlive.Should().BeFalse();
    }
}
