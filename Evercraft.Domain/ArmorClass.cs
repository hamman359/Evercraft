using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public class ArmorClass : ValueObject
{
    ArmorClass(int value)
    {
        Value = value;
    }

    public int Value { get; init; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    public static ArmorClass Create(int value)
    {
        return new(value);
    }
}