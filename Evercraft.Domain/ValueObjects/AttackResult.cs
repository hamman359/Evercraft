public class AttackResult
{
    protected internal AttackResult(bool isHit, bool isCritical)
    {
        IsHit = isHit;
        IsCritical = isCritical;
    }

    public bool IsHit { get; private set; }

    public bool IsMiss => !IsHit;

    public bool IsCritical { get; private set; }

    public static AttackResult Hit() => new(true, false);

    public static AttackResult CriticalHit() => new(true, true);

    public static AttackResult Miss() => new(false, false);
}
