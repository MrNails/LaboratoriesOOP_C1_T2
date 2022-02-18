using System;

namespace OOP_Labs_C1_T2.Lab6;

public class Trapezoid : IPrintableSquare
{
    private float m_topSide;
    private float m_downSide;
    private float m_height;

    public Trapezoid() : this(0, 0, 0) { }

    public Trapezoid(float topSide, float downSide, float height)
    {
        TopSide = topSide;
        DownSide = downSide;
        Height = height;
    }

    public float Square => (TopSide + DownSide) * Height / 2;
    
    public float TopSide
    {
        get => m_topSide;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            m_topSide = value;
        }
    }

    public float DownSide
    {
        get => m_downSide;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            m_downSide = value;
        }
    }

    public float Height
    {
        get => m_height;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            m_height = value;
        }
    }

    public void Print(Action<string> print)
    {
        print?.Invoke($"Square of trapezoid: {Square.ToString()}");
    }
}