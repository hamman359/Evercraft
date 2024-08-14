using Evercraft.Domain.AbilityModifiers;

namespace Evercraft.Domain.CharacterAttributes;

public sealed class StrengthCharacterAttribute : CharacterAttribute
{
    StrengthCharacterAttribute(int value)
        : base(AttributeType.Strength, value)
    {
        _modificationRules.Add(new StrengthAttackRollModifierRule(Modifier));
        _modificationRules.Add(new StrengthDamageModifierRule(Modifier));
        _modificationRules.Add(new StrengthCriticalHitDamageModifierRule(Modifier));
    }

    public static StrengthCharacterAttribute Create(int value)
    {
        ValidateValue(value);

        return new(value);
    }
}
