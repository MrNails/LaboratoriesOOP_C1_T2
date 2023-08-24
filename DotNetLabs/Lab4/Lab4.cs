using OOP_Labs_C1_T2.Core;

namespace DotNetLabs.Lab4;

public sealed class Lab4 : IExecutable
{
    public void Execute()
    {
        static double Func1(double x) => 1 / Math.Pow(x, -3); 
        static double Func2(double x) => Math.Exp(x) / Math.Sqrt(x); 
        static double Func3(double x) => Math.Log2(x); 

        Console.WriteLine($"Area under function[1/x^-3] curve [2,10] = {Integral(2,10,Func1)}");
        Console.WriteLine($"Area under function[e^x/x^-2] curve [1,35] = {Integral(1,35,Func2)}");
        Console.WriteLine($"Area under function[log2(x)] curve [2,10] = {Integral(2,10,Func3)}");
        
        var exit = false;

        Console.CancelKeyPress += (sender, args) =>
        {
            args.Cancel = true;
            exit = true;
        };

        Console.WriteLine("For cancel press Ctrl + C");
        while (!exit)
        {
            var key = Console.ReadKey();
            
            if (key.Key == ConsoleKey.D)
                Console.Write("enys");
        }
    }

    static double Integral(double start, double finish, Func<double,double> function, uint precision = 250)
    {
        precision = Math.Max(precision, 1);

        var res = 0d;
        var step = (finish - start) / precision;
            
        while(start < finish)
        {
            res += Math.Abs(function(start)) * step;
            start += step;
        }

        return res;
    }
}