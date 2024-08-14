namespace Evercraft.Domain.CharacterAttributes;
public sealed class WisdomCharacterAttribute : CharacterAttribute
{
    WisdomCharacterAttribute(int value)
        : base(AttributeType.Wisdom, value)
    {
        //_modificationRules.Add(new WisdomAttackRollModifierRule());
    }

    public static WisdomCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}
