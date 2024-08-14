namespace Evercraft.Domain;

public sealed class StrengthCharacterAttribute : CharacterAttribute
{
    StrengthCharacterAttribute(int value)
        : base(AttributeType.Strength, value)
    {
        _modificationRules.Add(new StrengthAttackRollModifierRule(Modifier));
        _modificationRules.Add(new StrengthDamageModifierRule(Modifier));
    }

    public static StrengthCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}

public sealed class DexterityCharacterAttribute : CharacterAttribute
{
    DexterityCharacterAttribute(int value)
        : base(AttributeType.Dexterity, value)
    {
        //_modificationRules.Add(new DexterityAttackRollModifierRule());
    }

    public static DexterityCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}
public sealed class ConstitutionCharacterAttribute : CharacterAttribute
{
    ConstitutionCharacterAttribute(int value)
        : base(AttributeType.Constitution, value)
    {
        //_modificationRules.Add(new ConstitutionAttackRollModifierRule());
    }

    public static ConstitutionCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}
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