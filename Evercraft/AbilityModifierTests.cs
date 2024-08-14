namespace Evercraft.Tests;

public class AbilityModifierTests
{
    [Fact]
    void CharactersStrength_Should_BeAddedToAttackRoll()
    {
        Character attacker = Character.Create().SetStrength(15);

        Character opponent = Character.Create();

        AttackResult result = attacker.Attack(opponent, Roll.Create(9));

        result.IsHit.Should().BeTrue();
    }

    [Fact]
    void CharactersStrength_Should_BeAddedToDamage()
    {
        Character attacker = Character.Create().SetStrength(15);

        Character opponent = Character.Create();

        AttackResult result = attacker.Attack(opponent, Roll.Create(15));

        result.Damage.Should().Be(3);
    }

    [Fact]
    void CharacterDamage_Should_BeAMinimumOf1()
    {
        Character attacker = Character.Create().SetStrength(5);

        Character opponent = Character.Create();

        AttackResult result = attacker.Attack(opponent, Roll.Create(15));

        result.Damage.Should().Be(1);
    }
}
