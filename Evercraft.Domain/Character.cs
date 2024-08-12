namespace Evercraft.Domain;

public class Character
{
    public Character(string characterName)
    {
        Name = characterName;
    }

    public string Name { get; private set; }
}
