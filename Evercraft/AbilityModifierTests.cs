namespace Evercraft.Tests;

public class AbilityModifierTests
{
    [Fact]
    void CharactersStrengthModifier_Should_BeAddedToAttackRoll()
    {
        Character attacker = Character.Create().SetStrength(15);

        Character opponent = Character.Create();

        AttackResult result = attacker.Attack(opponent, Roll.Create(9));

        result.IsHit.Should().BeTrue();
    }

    [Fact]
    void CharactersStrengthModifier_Should_BeAddedToDamage()
    {
        Character attacker = Character.Create().SetStrength(15);

        Character opponent = Character.Create();

        AttackResult result = attacker.Attack(opponent, Roll.Create(15));

        result.Damage.Should().Be(3); //Default Damage(1) + Strength Modifier(2)
    }

    [Fact]
    void CharacterDamage_Should_BeAMinimumOf1()
    {
        Character attacker = Character.Create().SetStrength(5);

        Character opponent = Character.Create();

        AttackResult result = attacker.Attack(opponent, Roll.Create(15));

        result.Damage.Should().Be(1);
    }

    [Fact]
    void CharactersStrengthModifier_Should_BeDoubledWhenAddedToCriticalHitDamage()
    {
        Character attacker = Character.Create().SetStrength(15);

        Character opponent = Character.Create();

        AttackResult result = attacker.Attack(opponent, Roll.Create(20));

        result.Damage.Should().Be(10);//Default Damage(1) + Strength Modifier * 2(2 * 2) * 2
    }

    [Fact]
    void CharactersDexterityModifier_Should_BeAddedToArmorClass()
    {
        Character character = Character.Create().SetDexterity(15);

        character.ArmorClass.ModifiedValue.Should().Be(12);
    }

    [Fact]
    void CharactersConstitutionModifier_Should_BeAddedToHitPoints()
    {
        Character character = Character.Create().SetConstitution(15);

        character.HitPoints.MaxHP.Should().Be(7);
    }

    [Fact]
    void CharacterHitPOints_Should_BeAMinimumOf1()
    {
        Character character = Character.Create().SetConstitution(1);

        character.HitPoints.MaxHP.Should().Be(1);
    }
}
