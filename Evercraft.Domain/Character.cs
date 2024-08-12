namespace Evercraft.Domain;

public sealed class Character
{
    Character() { }

    public string Name { get; private set; } = string.Empty;

    public static Character Create()
    {
        return new();
    }

    public Character SetName(string name)
    {
        Name = name;

        return this;
    }
}

