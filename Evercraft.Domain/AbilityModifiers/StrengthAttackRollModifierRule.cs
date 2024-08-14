namespace Evercraft.Domain.AbilityModifiers;

public sealed record StrengthAttackRollModifierRule
    : ModificationRule
{
    public StrengthAttackRollModifierRule(int modValue)
    {
        ModificationType = ModificationType.AttackRoll;

        ModValue = modValue;

        Rule = (toModify) => ModValue + toModify;

        IsUniqueRule = true;
    }
}
