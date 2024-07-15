using Evercraft.Domain.Primatives;

namespace Evercraft.Domain.ValueObjects;

public sealed class Roll : ValueObject
{
    Roll(int dieValue)
    {
        DieValue = dieValue;
    }

    public int DieValue { get; private set; }

    public bool IsCrit => DieValue == 20;

    public static Roll Create(int dieValue)
    {
        return new Roll(dieValue);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DieValue;
    }
}
