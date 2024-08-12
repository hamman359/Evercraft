using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public class AttackResult : ValueObject
{
    const int DefaultDamage = 1;

    AttackResult(bool isHit, bool isCritical)
    {
        IsHit = isHit;
        IsCritical = isCritical;
    }

    public bool IsHit { get; init; }

    public bool IsMiss => !IsHit;

    public bool IsCritical { get; init; }

    public int Damage
    {
        get
        {
            if(IsMiss)
                return 0;

            return IsCritical
                ? DefaultDamage * 2
                : DefaultDamage;
        }
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return IsHit;
        yield return IsCritical;
    }

    public static AttackResult Hit() => new(true, false);

    public static AttackResult CriticalHit() => new(true, true);

    public static AttackResult Miss() => new(false, false);
}