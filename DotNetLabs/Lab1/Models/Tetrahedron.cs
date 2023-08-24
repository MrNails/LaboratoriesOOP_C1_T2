namespace DotNetLabs.Lab1.Models;

public sealed class Tetrahedron : Body
{
    private double m_side;

    public double Side
    {
        get => m_side;
        set
        {
            ThrowIfLessThanZero(value, nameof(Side));
            m_side = value;
        }
    }

    public override double Area()
    {
        return Math.Pow(Side, 2) * Math.Sqrt(3);
    }

    public override double Volume()
    {
        return Math.Pow(Side, 3) * Math.Sqrt(2) / 12.0;
    }
}