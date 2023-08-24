namespace DotNetLab2;

public class FactorialClass
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
}