namespace Evercraft.Domain;

public sealed class Character
{
    public Character() { }

    public string Name { get; private set; } = string.Empty;

    public void SetName(string name) => Name = name;
}
