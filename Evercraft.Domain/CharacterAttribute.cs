using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public class CharacterAttribute : ValueObject
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


    CharacterAttribute(
        AttributeType attributeType,
        int value)
    {
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

    public static CharacterAttribute Create(AttributeType type, int value)
    {

        if(value < MinimumValue || value > MaximumValue)
        {
            throw new ArgumentOutOfRangeException($"Value must be between {MinimumValue} and {MaximumValue}");
        }

        return new(type, value);
    }
}
