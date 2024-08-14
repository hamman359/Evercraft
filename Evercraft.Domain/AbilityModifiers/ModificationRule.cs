namespace Evercraft.Domain.AbilityModifiers;

public abstract record ModificationRule
{
    public ModificationType ModificationType { get; protected set; }

    public Func<int, int> Rule { get; protected set; } = (x) => 0;

    public bool IsUniqueRule { get; protected set; }

    public int ModValue { get; protected set; }
}
