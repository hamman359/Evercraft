using Evercraft.Domain.Enums;

namespace Evercraft.Domain.ValueObjects;

public sealed class Constitution : CharacterAttribute
{
    public Constitution(int value)
        : base(value, AttributeType.Constitution)
    {
    }

}