using Evercraft.Domain.Enums;

namespace Evercraft.Domain.ValueObjects;

public sealed class Wisdom : CharacterAttribute
{
    public Wisdom(int value)
        : base(value, AttributeType.Wisdom)
    {
    }

}