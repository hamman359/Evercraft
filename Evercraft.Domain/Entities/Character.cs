using Evercraft.Domain.Enums;
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
        Strength = CharacterAttribute.Strength(10);
        Dexterity = CharacterAttribute.Dexterity(10);
        Constitution = CharacterAttribute.Constitution(10);
        Intelligence = CharacterAttribute.Intelligence(10);
        Wisdom = CharacterAttribute.Wisdom(10);
        Charisma = CharacterAttribute.Charisma(10);
    }

    public string Name { get; private set; }

    public Alignment Alignment { get; private set; }

    // ENHANCEMENT: Make Value Object? Or possibly class to encapuslate any logic around AC?
    public int ArmorClass { get; private set; }

    // ENHANCEMENT: Make Value Object? Or possibly class to encapuslate any logic around HP?
    public int HitPoints { get; private set; }

    public int MaxHitPoints { get; private set; }

    public bool IsAlive => HitPoints > 0;

    public CharacterAttribute Strength { get; internal set; }

    public CharacterAttribute Dexterity { get; internal set; }
    
    public CharacterAttribute Constitution { get; internal set; }
    
    public CharacterAttribute Wisdom { get; internal set; }
    
    public CharacterAttribute Intelligence { get; internal set; }
    
    public CharacterAttribute Charisma { get; internal set; }

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
            return AttackResult.CriticalHit();
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