using Evercraft.Domain.Enums;

namespace Evercraft.Domain.ValueObjects;

public sealed class Dexterity : CharacterAttribute
{
    public Dexterity(int value)
        : base(value, AttributeType.Dexterity)
    {
    }

}