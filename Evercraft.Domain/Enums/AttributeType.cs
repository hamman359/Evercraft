using Evercraft.Domain.Primatives;

namespace Evercraft.Domain.Enums;

public class AttributeType : Enumeration<AttributeType>
{
    public static readonly AttributeType Strength = new(1, "Strength");
    public static readonly AttributeType Dexterity = new(2, "Dexterity");
    public static readonly AttributeType Constitution = new(3, "Constitution");
    public static readonly AttributeType Intelligence = new(4, "Intelligence");
    public static readonly AttributeType Wisdom = new(5, "Wisdom");
    public static readonly AttributeType Charisma = new(6, "Charisma");

    public AttributeType(int value, string name)
        : base(value, name)
    {
    }
}
