using System;
using OOP_Labs_C1_T2.Core;

namespace OOP_Labs_C1_T2.Lab6;

public class Lab6 : IExecutable
{
    public void Execute()
    {
        var trapezoid1 = new Trapezoid();
        var trapezoid2 = new Trapezoid(5, 10, 10);

        trapezoid1.Height = 5;
        trapezoid1.DownSide = 3;
        trapezoid1.TopSide = 7;

        Console.WriteLine("Trapezoid 1:");
        trapezoid1.Print(Console.WriteLine);
        
        Console.WriteLine("Trapezoid 2:");
        trapezoid2.Print(Console.WriteLine);
    }
}