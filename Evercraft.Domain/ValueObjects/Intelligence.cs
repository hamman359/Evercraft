using Evercraft.Domain.Enums;

namespace Evercraft.Domain.ValueObjects;

public sealed class Intelligence : CharacterAttribute
{
    public Intelligence(int value)
        : base(value, AttributeType.Intelligence)
    {
    }

}