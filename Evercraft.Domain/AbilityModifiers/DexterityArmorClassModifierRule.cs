namespace Evercraft.Domain.AbilityModifiers;

public sealed record DexterityArmorClassModifierRule : ModificationRule
{
    public DexterityArmorClassModifierRule(int modValue)
    {
        ModificationType = ModificationType.ArmorClass;

        ModValue = modValue;

        Rule = (toModify) => ModValue + toModify;

        IsUniqueRule = true;
    }
}