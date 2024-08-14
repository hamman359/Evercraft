using Evercraft.Domain.AbilityModifiers;

using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public sealed class ArmorClass : ValueObject
{
    ArmorClass(int value, List<ModificationRule> rules)
    {
        BaseValue = value;
        ModifiedValue = BaseValue;

        foreach(var rule in rules)
        {
            ModifiedValue = rule.Rule(ModifiedValue);
        }
    }

    public int ModifiedValue { get; init; }

    public int BaseValue { get; init; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return BaseValue;
        yield return ModifiedValue;
    }

    public static ArmorClass Create(int value, List<ModificationRule> rules)
    {
        return new(value, rules);
    }
}