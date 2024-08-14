namespace Evercraft.Domain.AbilityModifiers;

public static class ModificationRuleExtensions
{
    public static List<ModificationRule> GetModifiersToApply(this List<ModificationRule> rules, ModificationType type)
    {
        return rules.Where(x => x.ModificationType == type).ToList();
    }

}