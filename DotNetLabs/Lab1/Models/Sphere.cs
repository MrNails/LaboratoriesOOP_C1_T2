namespace DotNetLabs.Lab1.Models;

public sealed class Sphere : Body
{
    private double m_radius;

    public double Radius
    {
        get => m_radius;
        set
        {
            ThrowIfLessThanZero(value, nameof(Radius));
            
            m_radius = value;
        }
    }

    public override double Area()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }

    public override double Volume()
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
    }
}