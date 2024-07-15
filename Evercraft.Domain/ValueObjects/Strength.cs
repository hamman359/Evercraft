using Evercraft.Domain.Enums;

namespace Evercraft.Domain.ValueObjects;

public sealed class Strength : CharacterAttribute
{
    public Strength(int value)
        : base(value, AttributeType.Strength)
    {
    }

}
