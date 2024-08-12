using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public sealed class HitPoints : ValueObject
{
    HitPoints(int maxHP, int currentHP)
    {
        MaxHP = maxHP;
        CurrentHP = currentHP;

    }

    public int MaxHP { get; init; }

    public int CurrentHP { get; init; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return MaxHP;
    }

    public static HitPoints Create(int value)
    {
        return new(value, value);
    }

    public HitPoints ApplyDamage(int damage)
    {
        return new(MaxHP, CurrentHP - damage);
    }
}