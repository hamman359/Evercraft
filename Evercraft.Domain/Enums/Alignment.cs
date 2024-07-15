using Evercraft.Domain.Primatives;

namespace Evercraft.Domain.Enums;

public sealed class Alignment : Enumeration<Alignment>
{
    public static readonly Alignment Good = new(1, "Good");
    public static readonly Alignment Evil = new(2, "Evil");
    public static readonly Alignment Neutral = new(3, "Neutral");

    public Alignment(int value, string name)
        : base(value, name)
    {
    }

}