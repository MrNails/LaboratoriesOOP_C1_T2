using System;
using System.Globalization;
using OOP_Labs_C1_T2.Core;

namespace OOP_Labs_C1_T2.Lab8;

public class Lab8 : IExecutable
{
    private static readonly string s_name = "enys";
    
    private delegate double FunctionDelegate(double x);
    private delegate void KeyInputDelegate(char key);

    private event KeyInputDelegate KeyPressed;
    
    private Func<string, double?> m_converter;
    private Func<double?, bool> m_check;

    public Lab8()
    {
        m_converter = input =>
        {
            var result = 0.0;
            var convRes = double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out result);

            return convRes ? result : null;
        };
        
        m_check = number => number.HasValue && number != 0;

        KeyPressed += OnKeyPressed;
    }
    
    private FunctionDelegate Func1 => x => 1 / x;
    private FunctionDelegate Func2 => x => Math.Sqrt(4 + Math.Pow(x, 2));
    private FunctionDelegate Func3 => x => Math.Sin(ConvertToRadians(x));
    
    public void Execute()
    {
        Console.WriteLine("Laboratory 8\nTask 1");
        Task1();
        Console.WriteLine("Task 2");
        Task2();
    }

    private void Task1()
    {
        double x, a, b;

        x = Helpers.Input("Enter x: ", "Wrong enter. There is an error in your input or x equal 0.", m_converter, m_check)!.Value;
        a = Helpers.Input("Enter a: ", "Wrong enter.", m_converter, _a => _a.HasValue)!.Value;
        b = Helpers.Input("Enter b: ", "Wrong enter.", m_converter, _b => _b.HasValue)!.Value;
        
        Console.WriteLine($"Integral of function 1/x where x = {x} and in range [{a};{b}] is {TrapezoidMethod(a, b, Func1)}");
        Console.WriteLine($"Integral of function sqrt(4 + x^2) where x = {x} and in range [{a};{b}] is {TrapezoidMethod(a, b, Func2)}");
        Console.WriteLine($"Integral of function sin(x) where x = {x} and in range [{a};{b}] is {TrapezoidMethod(a, b, Func3)}");
    }

    private void Task2()
    {
        bool exit = false;

        Console.CancelKeyPress += (sender, args) =>
        {
            args.Cancel = true;
            exit = true;
        };

        Console.WriteLine("For cancel press Ctrl + C");
        while (!exit)
        {
            var key = Console.ReadKey();

            KeyPressed(key.KeyChar);
        }
    }

    private void OnKeyPressed(char key)
    {
        if (char.ToLower(key) == 'd')
            Console.Write(s_name);
    }

    static double TrapezoidMethod(double a, double b, FunctionDelegate func, short precision = 50)
    {
        if (precision == 0) 
            precision = 1;

        precision = Math.Abs(precision);
        
        var step = Math.Abs(b - a) / precision;
        var res = (func(a) + func(b)) / 2;

        for (var k = a + step; k < b; k += step) 
            res += func(k);
            
        return Math.Abs(res * step);
    }
    
    private static double ConvertToRadians(double angle)
    {
        return (Math.PI / 180) * angle;
    }
}