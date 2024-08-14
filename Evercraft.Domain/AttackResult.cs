using Evercraft.Domain.AbilityModifiers;

using KJWT.SharedKernel.Primatives;

namespace Evercraft.Domain;

public class AttackResult : ValueObject
{
    const int DefaultDamage = 1;

    AttackResult(bool isHit, bool isCritical,
    List<ModificationRule> rules)
    {
        IsHit = isHit;
        IsCritical = isCritical;

        if(IsHit)
        {
            Damage = CalculateDamage(rules);
        }


        int CalculateDamage(List<ModificationRule> rules)
        {
            var damage = DefaultDamage;

            if(IsCritical)
            {
                foreach(var mod in rules.GetModifiersToApply(ModificationType.CriticalHitDamage))
                {
                    damage = mod.Rule(damage);
                }

                damage = damage * 2;
            }
            else
            {

                foreach(var mod in rules.GetModifiersToApply(ModificationType.Damage))
                {
                    damage = mod.Rule(damage);
                }
            }

            return damage >= 1
                ? damage
                : 1;
        }
    }

    //var damageMods = rules.GetModifiersToApply(ModificationType.Damage);



    public bool IsHit { get; init; }

    public bool IsMiss => !IsHit;

    public bool IsCritical { get; init; }

    public int Damage { get; init; } = 0;

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return IsHit;
        yield return IsCritical;
    }

    public static AttackResult Create(
        Roll roll,
        Character opponent,
        List<ModificationRule> rules)
    {
        if(roll.ModifiedValue < opponent.ArmorClass.Value) //Miss
        {
            return new(false, false, rules);
        }

        if(roll.DieValue == 20) //Critical Hit
        {
            return new(true, true, rules);
        }

        return new(true, false, rules); //Hit
    }
}