using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;
public sealed class Roll : ValueObject
{
    Roll(int dieValue)
    {
        DieValue = dieValue;
    }

    public int DieValue { get; init; }

    public int ModifiedValue { get; private set; }

    public static Roll Create(int dieValue)
    {
        return new(dieValue);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DieValue;
    }

    public void ApplyModifiers(List<ModificationRule> modifications)
    {
        ModifiedValue = DieValue;

        foreach(ModificationRule rule in modifications)
        {
            ModifiedValue = rule.Rule(DieValue);
        }
    }
}
