namespace DotNetLabs.Lab1.Models;

public class Parallelepiped : Body
{
    private double m_width;
    private double m_height;
    private double m_length;

    public double Width
    {
        get => m_width;
        set
        {
            ThrowIfLessThanZero(value, nameof(Width));
            m_width = value;
        }
    }

    public double Height
    {
        get => m_height;
        set
        {
            ThrowIfLessThanZero(value, nameof(Height));
            m_height = value;
        }
    }

    public double Length
    {
        get => m_length;
        set
        {
            ThrowIfLessThanZero(value, nameof(Length));
            m_length = value;
        }
    }

    public override double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }

    public override double Volume()
    {
        return Width * Height * Length;
    }
}