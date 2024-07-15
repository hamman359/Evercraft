public class Character
{
    public Character(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public Alignment Alignment { get; private set; }

    public void ChangeName(string newName) =>
        Name = newName;

    public void AssignGoodAlignment() =>
        Alignment = Alignment.Good;

    public void AssignEvilAlignment() =>
        Alignment = Alignment.Evil;

    public void AssignNeutralAlignment() =>
        Alignment = Alignment.Neutral;
}
