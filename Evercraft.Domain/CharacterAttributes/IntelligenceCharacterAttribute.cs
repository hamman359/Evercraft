namespace Evercraft.Domain.CharacterAttributes;
public sealed class IntelligenceCharacterAttribute : CharacterAttribute
{
    IntelligenceCharacterAttribute(int value)
        : base(AttributeType.Intelligence, value)
    {
        //_modificationRules.Add(new DexterityAttackRollModifierRule());
    }

    public static IntelligenceCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}
