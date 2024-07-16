using Evercraft.Domain.Enums;

namespace Evercraft.Domain.ValueObjects;

public sealed class Charisma : CharacterAttribute
{
    public Charisma(int value)
        : base(value, AttributeType.Charisma)
    {
    }

}