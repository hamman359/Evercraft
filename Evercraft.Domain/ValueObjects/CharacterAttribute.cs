using Evercraft.Domain.Enums;
using Evercraft.Domain.Primatives;

namespace Evercraft.Domain.ValueObjects;

public abstract class CharacterAttribute : ValueObject
{
    public const int MinimumValue = 1;
    public const int MaximumValue = 20;

    readonly Dictionary<int, int> _modifierLookup = new Dictionary<int, int>
    {
        { 1, -5 },
        { 2, -4 },
        { 3, -4 },
        { 4, -3 },
        { 5, -3 },
        { 6, -2 },
        { 7, -2 },
        { 8, -1 },
        { 9, -1 },
        { 10, 0 },
        { 11, 0 },
        { 12, 1 },
        { 13, 1 },
        { 14, 2 },
        { 15, 2 },
        { 16, 3 },
        { 17, 3 },
        { 18, 4 },
        { 19, 4 },
        { 20, 5 }
    };


    protected CharacterAttribute(
        int value,
        AttributeType attributeType)
    {
        if(value < MinimumValue || value > MaximumValue)
        {
            throw new ArgumentOutOfRangeException($"Value must be between {MinimumValue} and {MaximumValue}");
        }

        Value = value;
        AttributeType = attributeType;
    }

    public int Value { get; set; }

    public AttributeType AttributeType { get; set; }

    public int Modifier => _modifierLookup[Value];

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
