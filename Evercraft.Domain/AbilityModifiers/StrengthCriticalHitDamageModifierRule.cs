namespace Evercraft.Domain.AbilityModifiers;

public sealed record StrengthCriticalHitDamageModifierRule
    : ModificationRule
{
    public StrengthCriticalHitDamageModifierRule(int modValue)
    {
        ModificationType = ModificationType.CriticalHitDamage;

        ModValue = modValue;

        Rule = (toModify) => ModValue * 2 + toModify;

        IsUniqueRule = true;
    }
}