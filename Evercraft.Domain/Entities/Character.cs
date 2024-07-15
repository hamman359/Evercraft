using Evercraft.Domain.ValueObjects;

namespace Evercraft.Domain.Entities;

public sealed class Character
{
    public Character(string name)
    {
        Name = name;
        Alignment = Alignment.Neutral;
        ArmorClass = 10;
        MaxHitPoints = 5;
        HitPoints = 5;
    }

    public string Name { get; private set; }

    public Alignment Alignment { get; private set; }

    // ENHANCEMENT: Make Value Object? Or possibly class to encapuslate any logic around AC?
    public int ArmorClass { get; private set; }

    // ENHANCEMENT: Make Value Object? Or possibly class to encapuslate any logic around HP?
    public int HitPoints { get; private set; }
    public int MaxHitPoints { get; private set; }

    public bool IsAlive => HitPoints > 0;

    public void ChangeName(string newName) =>
        Name = newName;

    public void AssignGoodAlignment() =>
        Alignment = Alignment.Good;

    public void AssignEvilAlignment() =>
        Alignment = Alignment.Evil;

    public void AssignNeutralAlignment() =>
        Alignment = Alignment.Neutral;

    public void SetArmorClass(int ac) =>
        ArmorClass = ac;

    public AttackResult Attack(Roll roll, Character toAttack)
    {

        if(roll.IsCrit)
        {
            return AttackResult.Hit();
        }

        if(roll.DieValue >= toAttack.ArmorClass)
        {
            return AttackResult.Hit();
        }

        return AttackResult.Miss();
    }

    public void TakeDamage(AttackResult result)
    {
        if(result.IsMiss)
        {
            return;
        }

        HitPoints -= result.Damage;
    }
}