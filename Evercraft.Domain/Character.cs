
namespace Evercraft.Domain;

public sealed class Character
{
    Character()
    {
        SetName(string.Empty);
        SetAlignment(Alignment.Neutral);
        SetArmorClass(10);
        SetHitPoints(5);
        SetStrength(10);
        SetDexterity(10);
        SetConstitution(10);
        SetWisdom(10);
        SetIntelligence(10);
        SetCharisma(10);
    }

    public string Name { get; private set; }

    public Alignment Alignment { get; private set; }

    public ArmorClass ArmorClass { get; private set; }

    public HitPoints HitPoints { get; private set; }

    public bool IsAlive => HitPoints.CurrentHP > 0;

    public CharacterAttribute Strength { get; private set; }

    public CharacterAttribute Dexterity { get; private set; }

    public CharacterAttribute Constitution { get; private set; }

    public CharacterAttribute Wisdom { get; private set; }

    public CharacterAttribute Intelligence { get; private set; }

    public CharacterAttribute Charisma { get; private set; }

    private readonly List<ModificationRule> _modificationRules = new();

    public static Character Create()
    {
        return new();
    }

    public Character SetName(string name)
    {
        Name = name;

        return this;
    }

    public Character SetAlignment(Alignment alignment)
    {
        Alignment = alignment;

        return this;
    }
    void SetArmorClass(int value)
    {
        ArmorClass = ArmorClass.Create(value);
    }

    void SetHitPoints(int value)
    {
        HitPoints = HitPoints.Create(value);
    }

    public AttackResult Attack(Character opponent, Roll roll)
    {
        roll.ApplyModifiers(_modificationRules.GetModifiersToApply(ModificationType.AttackRoll));

        return AttackResult.Create(roll, opponent, _modificationRules);
    }

    public void ApplyDamage(AttackResult attackResult)
    {
        HitPoints = HitPoints.ApplyDamage(attackResult.Damage);
    }

    public Character SetStrength(int value)
    {
        Strength = StrengthCharacterAttribute.Create(value);

        Strength.ApplyModificationRules(_modificationRules);

        return this;
    }

    public Character SetDexterity(int value)
    {
        Dexterity = DexterityCharacterAttribute.Create(value);

        return this;
    }

    public Character SetConstitution(int value)
    {
        Constitution = ConstitutionCharacterAttribute.Create(value);

        return this;
    }

    public Character SetWisdom(int value)
    {
        Wisdom = WisdomCharacterAttribute.Create(value);

        return this;
    }

    public Character SetIntelligence(int value)
    {
        Intelligence = IntelligenceCharacterAttribute.Create(value);

        return this;
    }

    public Character SetCharisma(int value)
    {
        Charisma = CharismaCharacterAttribute.Create(value);

        return this;
    }
}
