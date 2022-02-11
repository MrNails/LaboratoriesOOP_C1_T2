using System;

namespace OOP_Labs_C1_T2.Lab4;

public class ComplexNumber
{
    private float m_real;
    private float m_imagine;

    public ComplexNumber() : this(0.0f, 0.0f) { }

    public ComplexNumber(float real, float imagine)
    {
        Real = real;
        Imagine = imagine;
    }

    public float Real
    {
        get => m_real;
        set
        {
            m_real = value;
        }
    }
    
    public float Imagine
    {
        get => m_imagine;
        set
        {
            m_imagine = value;
        }
    }

    public override string ToString()
    {
        var sign = Imagine < 0 ? "-" : "+";

        return $"{Real} {sign} {Math.Abs(Imagine)}i";
    }

    public override bool Equals(object? obj)
    {
        var right = obj as ComplexNumber;
        
        if (right == null)
            return false;

        return Real == right.Real &&
               Imagine == right.Imagine;
    }

    public static ComplexNumber operator+(ComplexNumber left, ComplexNumber right)
    {
        left.Real += right.Real;
        left.Imagine += right.Imagine;

        return left;
    }
    public static ComplexNumber operator-(ComplexNumber left, ComplexNumber right)
    {
        left.Real -= right.Real;
        left.Imagine -= right.Imagine;

        return left;
    }
    
    public static ComplexNumber operator+(ComplexNumber left, float right)
    {
        left.Real += right;

        return left;
    }
    public static ComplexNumber operator-(ComplexNumber left, float right)
    {
        left.Real -= right;

        return left;
    }
}