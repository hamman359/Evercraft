using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public class Alignment : Enumeration<Alignment>
{
    public static readonly Alignment Good = new(1, "Good");
    public static readonly Alignment Neutral = new(2, "Neutral");
    public static readonly Alignment Evil = new(3, "Evil");

    Alignment(int id, string name)
        : base(id, name)
    {
    }
}