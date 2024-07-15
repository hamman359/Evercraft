public class Character
{
    public Character(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public string Alignment { get; private set; }

    public void ChangeName(string newName) =>
        Name = newName;

    public void AssignGoodAlignment() =>
        Alignment = "Good";

    public void AssignEvilAlignment() =>
        Alignment = "Evil";

    public void AssignNeutralAlignment() =>
        Alignment = "Neutral";
}
