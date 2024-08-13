using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public abstract class CharacterAttribute : ValueObject
{
    public const int MinimumValue = 1;
    public const int MaximumValue = 20;

    protected readonly Dictionary<int, int> _modifierLookup = new Dictionary<int, int>
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

    protected readonly List<ModificationRule> _modificationRules = new();

    protected CharacterAttribute(
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

    protected static void ValidateValue(int value)
    {
        //TODO: Modify to return a result instead of throw an exception
        if(value < MinimumValue || value > MaximumValue)
        {
            throw new ArgumentOutOfRangeException($"Value must be between {MinimumValue} and {MaximumValue}");
        }
    }

    public void ApplyModificationRules(List<ModificationRule> rules)
    {
        foreach(var rule in _modificationRules)
        {
            if(rule.IsUniqueRule)
            {
                RemoveExistingRule(rules, rule);
            }

            rules.Add(rule);
        }

        static void RemoveExistingRule(List<ModificationRule> rules, ModificationRule rule)
        {
            var toRemove = rules.Find(r => r.GetType() == rule.GetType());

            if(toRemove is not null)
            {
                //This rule already exists and should be replaced
                rules.Remove(toRemove);
            }
        }
    }
}
