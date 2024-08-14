namespace Evercraft.Domain;

public sealed record StrengthDamageModifierRule
    : ModificationRule
{
    public StrengthDamageModifierRule(int modValue)
    {
        ModificationType = ModificationType.Damage;

        ModValue = modValue;

        Rule = (toModify) => ModValue + toModify;

        IsUniqueRule = true;
    }
}