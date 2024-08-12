using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public class AttackResult : ValueObject
{
    AttackResult(bool isHit, bool isCritical)
    {
        IsHit = isHit;
        IsCritical = isCritical;
    }

    public bool IsHit { get; init; }

    public bool IsMiss => !IsHit;

    public bool IsCritical { get; init; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return IsHit;
        yield return IsCritical;
    }

    public static AttackResult Hit() => new(true, false);

    public static AttackResult CriticalHit() => new(true, true);

    public static AttackResult Miss() => new(false, false);
}