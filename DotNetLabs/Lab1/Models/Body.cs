namespace DotNetLabs.Lab1.Models;

public abstract class Body
{
    public abstract double Area();
    public abstract double Volume();

    protected static void ThrowIfLessThanZero(double value, string fieldName)
    {
        if (value < 0) throw new ArgumentException($"{fieldName} cannot be less than 0");
    }
}