namespace DotNetLab2;

public class DynamicClass
{
    public long Factorial(int value)
    {
        long result = 1;
        var absValue = Math.Abs(value);

        while (absValue > 1)
        {
            result *= absValue--;
        }

        return result * (value < 0 && value % 2 != 0 ? -1 : 1);
    }

    public double TriangleArea(double sideA, double sideB, double sideC)
    {
        var sidesZeroOrLess = sideA <= 0 || sideB <= 0 || sideC <= 0;
        var sideLessThanOtherSides = sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA;

        if (sidesZeroOrLess || sideLessThanOtherSides)
        {
            return -1;
        }

        var s = (sideA + sideB + sideC) / 2;

        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }
}