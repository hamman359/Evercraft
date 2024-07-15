namespace Evercraft;

public sealed class Roll : ValueObject
{
    Roll(int value)
    {
        Value = value;
    }

    public int Value { get; private set; }

    public bool IsCrit => Value == 20;

    public static Roll Create(int value)
    {
        return new Roll(value);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
