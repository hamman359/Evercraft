using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;
public sealed class Roll : ValueObject
{
    Roll(int dieValue)
    {
        DieValue = dieValue;
    }

    public int DieValue { get; init; }

    public static Roll Create(int dieValue)
    {
        return new(dieValue);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DieValue;
    }
}
