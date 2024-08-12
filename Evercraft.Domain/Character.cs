
namespace Evercraft.Domain;

public sealed class Character
{
    Character() { }

    public string Name { get; private set; } = string.Empty;

    public Alignment Alignment { get; private set; } = Alignment.Neutral;

    public ArmorClass ArmorClass { get; private set; } = ArmorClass.Create(10);

    public HitPoints HitPoints { get; private set; } = HitPoints.Create(5);

    public bool IsAlive => HitPoints.CurrentHP > 0;

    public CharacterAttribute Strength { get; private set; } = CharacterAttribute.Create(AttributeType.Strength, 10);

    public CharacterAttribute Dexterity { get; private set; } = CharacterAttribute.Create(AttributeType.Dexterity, 10);

    public CharacterAttribute Constitution { get; private set; } = CharacterAttribute.Create(AttributeType.Constitution, 10);

    public CharacterAttribute Wisdom { get; private set; } = CharacterAttribute.Create(AttributeType.Wisdom, 10);

    public CharacterAttribute Intelligence { get; private set; } = CharacterAttribute.Create(AttributeType.Intelligence, 10);

    public CharacterAttribute Charisma { get; private set; } = CharacterAttribute.Create(AttributeType.Charisma, 10);

    public static Character Create()
    {
        return new();
    }

    public Character SetName(string name)
    {
        Name = name;

        return this;
    }

    public Character SetAlignment(Alignment alignment)
    {
        Alignment = alignment;

        return this;
    }

    public AttackResult Attack(Character opponent, Roll roll)
    {
        return roll.DieValue >= opponent.ArmorClass.Value
            ? AttackResult.Hit()
            : AttackResult.Miss();
    }

    public void ApplyDamage(AttackResult attackResult)
    {
        HitPoints = HitPoints.ApplyDamage(attackResult.Damage);
    }
}