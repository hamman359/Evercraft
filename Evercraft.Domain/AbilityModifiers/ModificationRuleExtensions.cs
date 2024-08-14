namespace Evercraft.Domain.AbilityModifiers;

public static class ModificationRuleExtensions
{
    public static List<ModificationRule> GetModifiersToApply(this List<ModificationRule> rules, ModificationType type)
    {
        return rules.Where(x => x.ModificationType == type).ToList();
    }

    public static void ApplyModificationRules(this List<ModificationRule> rules, IReadOnlyCollection<ModificationRule> toAdd)
    {
        foreach(var rule in toAdd)
        {
            if(rule.IsUniqueRule)
            {
                RemoveExistingRule(rule);
            }

            rules.Add(rule);
        }

        void RemoveExistingRule(ModificationRule rule)
        {
            var toRemove = rules.Find(r => r.GetType() == rule.GetType());

            if(toRemove is not null)
            {
                //This rule already exists and should be replaced
                rules.Remove(toRemove);
            }
        }
    }
}