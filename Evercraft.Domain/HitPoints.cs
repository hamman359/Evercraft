using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public class HitPoints : ValueObject
{
    HitPoints(int value)
    {
        Value = value;
    }

    public int Value { get; init; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    public static HitPoints Create(int value)
    {
        return new(value);
    }

    public HitPoints ApplyDamage(int damage)
    {
        return new(Value - damage);
    }
}