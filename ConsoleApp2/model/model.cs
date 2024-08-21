namespace MyNamespace.model;

public struct Mybio
{
    public string Name;
    public int Age;
    public string Gender;
    public Mybio(string name, int ages, string gender)
    {
        Name = name;
        Age = ages;
        Gender = gender;
    }

    public override string ToString() => $"{Name} {Age} {Gender}";
}

public struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}