namespace Evercraft.Domain.AbilityModifiers;

public sealed record ConstitutionHipPointModifierRule : ModificationRule
{
    public ConstitutionHipPointModifierRule(int modValue)
    {
        ModificationType = ModificationType.HitPoints;

        ModValue = modValue;

        Rule = (toModify) => ModValue + toModify;

        IsUniqueRule = true;
    }
}
