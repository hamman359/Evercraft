namespace Evercraft;

public sealed class Character
{
    public Character(string name)
    {
        Name = name;
        Alignment = Alignment.Neutral;
        ArmorClass = 10;
        Hitpoints = 5;
    }

    public string Name { get; private set; }

    public Alignment Alignment { get; private set; }

    // ENHANCEMENT: Make Value Object? Or possibly class to encapuslate any logic around AC?
    public int ArmorClass { get; private set; }

    // ENHANCEMENT: Make Value Object? Or possibly class to encapuslate any logic around HP?
    public int Hitpoints { get; private set; }

    public void ChangeName(string newName) =>
        Name = newName;

    public void AssignGoodAlignment() =>
        Alignment = Alignment.Good;

    public void AssignEvilAlignment() =>
        Alignment = Alignment.Evil;

    public void AssignNeutralAlignment() =>
        Alignment = Alignment.Neutral;

    public void SetArmorClass(int ac) =>
        ArmorClass = ac;

    public AttackResult Attack(Roll roll, Character toAttack)
    {

        if(roll.IsCrit)
        {
            return AttackResult.Hit();
        }

        if(roll.Value >= toAttack.ArmorClass)
        {
            return AttackResult.Hit();
        }

        return AttackResult.Miss();
    }
}

