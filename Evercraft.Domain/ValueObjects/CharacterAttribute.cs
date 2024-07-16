using Evercraft.Domain.Enums;
using Evercraft.Domain.Primatives;

namespace Evercraft.Domain.ValueObjects;

public abstract class CharacterAttribute : ValueObject
{
    protected CharacterAttribute(int value, AttributeType attributeType)
    {
        Value = value;
        AttributeType = attributeType;
    }

    public int Value { get; set; }

    public AttributeType AttributeType { get; set; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
        yield return AttributeType;
    }

    internal static CharacterAttribute Strength(int value) =>
        new Strength(value);

    internal static CharacterAttribute Dexterity(int value) =>
        new Dexterity(value);

    internal static CharacterAttribute Constitution(int value) =>
        new Constitution(value);

    internal static CharacterAttribute Wisdom(int value) =>
        new Wisdom(value);

    internal static CharacterAttribute Intelligence(int value) =>
        new Intelligence(value);

    internal static CharacterAttribute Charisma(int value) =>
        new Charisma(value);
}
