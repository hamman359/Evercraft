public class AttackResult
{
    protected internal AttackResult(bool isHit)
    {
        IsHit = isHit;
    }

    public bool IsHit { get; private set; }

    public bool IsMiss => !IsHit;

    public static AttackResult Hit() => new(true);

    public static AttackResult Miss() => new(false);
}
