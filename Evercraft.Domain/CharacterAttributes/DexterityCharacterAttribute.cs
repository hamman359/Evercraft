using Evercraft.Domain.AbilityModifiers;

namespace Evercraft.Domain.CharacterAttributes;

public sealed class DexterityCharacterAttribute : CharacterAttribute
{
    DexterityCharacterAttribute(int value)
        : base(AttributeType.Dexterity, value)
    {
        _modificationRules.Add(new DexterityArmorClassModifierRule(Modifier));
    }

    public static DexterityCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}
