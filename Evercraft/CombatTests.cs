namespace Evercraft;

public class CombatTests
{
    readonly Character _attacker;
    readonly Character _defender;

    public CombatTests()
    {
        _attacker = new Character("Attacker");
        _defender = new Character("Defender");
    }

    [Fact]
    void CharacterCanAttack()
    {
        var result = _attacker.Attack(Roll.Create(10), _defender);

        result.Should().NotBeNull();
    }

    [Theory]
    [InlineData(11)]
    [InlineData(12)]
    [InlineData(13)]
    [InlineData(14)]
    [InlineData(15)]
    [InlineData(16)]
    [InlineData(17)]
    [InlineData(18)]
    [InlineData(19)]
    [InlineData(20)]
    void AttackRollThatBeatsDefendersACIsAHit(int roll)
    {
        var result = _attacker.Attack(Roll.Create(roll), _defender);

        result.IsHit.Should().Be(true);
        result.IsMiss.Should().Be(false);
    }

    [Fact]
    void AttackRollThatMatchesDefendersACIsAHit()
    {
        var result = _attacker.Attack(Roll.Create(10), _defender);

        result.IsHit.Should().Be(true);
        result.IsMiss.Should().Be(false);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(9)]
    void AttackRollThatDoesNotBeatDefendersACIsAMiss(int roll)
    {
        var result = _attacker.Attack(Roll.Create(roll), _defender);

        result.IsMiss.Should().Be(true);
        result.IsHit.Should().Be(false);
    }

    [Theory]
    [InlineData(10)]
    [InlineData(15)]
    [InlineData(20)]
    [InlineData(25)]
    void AttackRollThatIsANatural20AlwaysHits(int defenderAC)
    {
        _defender.SetArmorClass(defenderAC);

        var result = _attacker.Attack(Roll.Create(20), _defender);

        result.IsHit.Should().Be(true);
        result.IsMiss.Should().Be(false);
    }
}
