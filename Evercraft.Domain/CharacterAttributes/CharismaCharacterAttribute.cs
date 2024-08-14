namespace Evercraft.Domain.CharacterAttributes;
public sealed class CharismaCharacterAttribute : CharacterAttribute
{
    CharismaCharacterAttribute(int value)
        : base(AttributeType.Charisma, value)
    {
        //_modificationRules.Add(new CharismaAttackRollModifierRule());
    }

    public static CharismaCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}