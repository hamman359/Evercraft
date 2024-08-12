
namespace Evercraft.Domain;

public sealed class Character
{
    Character() { }

    public string Name { get; private set; } = string.Empty;

    public Alignment Alignment { get; private set; } = Alignment.Neutral;

    public int ArmorClass { get; private set; } = 10;

    public int HitPoints { get; private set; } = 5;

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
        return roll.DieValue >= opponent.ArmorClass
            ? AttackResult.Hit()
            : AttackResult.Miss();
    }

    public void ApplyDamage(AttackResult attackResult)
    {
        HitPoints -= attackResult.Damage;
    }
}