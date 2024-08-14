using Evercraft.Domain.AbilityModifiers;

using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public sealed class HitPoints : ValueObject
{
    public const int BaseHP = 5;

    HitPoints(int maxHP, int currentHP, List<ModificationRule> rules)
    {
        MaxHP = BaseHP;

        foreach(var rule in rules.Where(x => x.ModificationType == ModificationType.HitPoints))
        {
            MaxHP = rule.Rule(MaxHP);
        }

        if(MaxHP < 1)
        {
            MaxHP = 1;
        }

        CurrentHP = currentHP;
    }

    public int MaxHP { get; init; }

    public int CurrentHP { get; private set; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return MaxHP;
    }

    public static HitPoints Create(int value, List<ModificationRule> rules)
    {
        return new(value, value, rules);
    }

    public HitPoints ApplyDamage(int damage, List<ModificationRule> rules)
    {
        return new(MaxHP, CurrentHP - damage, rules);
    }
}