namespace Evercraft.Domain;

public abstract record ModificationRule
{
    public ModificationType ModificationType { get; protected set; }

    public Func<int, int> Rule { get; protected set; } = (x) => 0;

    public bool IsUniqueRule { get; protected set; }

    public int ModValue { get; protected set; }
}

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