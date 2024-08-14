using Evercraft.Domain.AbilityModifiers;

namespace Evercraft.Domain.CharacterAttributes;

public sealed class ConstitutionCharacterAttribute : CharacterAttribute
{
    ConstitutionCharacterAttribute(int value)
        : base(AttributeType.Constitution, value)
    {
        _modificationRules.Add(new ConstitutionHipPointModifierRule(Modifier));
    }

    public static ConstitutionCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}
