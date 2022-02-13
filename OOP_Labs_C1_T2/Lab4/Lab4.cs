using System;
using OOP_Labs_C1_T2.Core;

namespace OOP_Labs_C1_T2.Lab4;

public class Lab4 : IExecutable
{
    public void Execute()
    {
        Console.WriteLine("Laboratory work 4");
        ComplexNumber num1 = new ComplexNumber(), 
            num2 = new ComplexNumber(3, -5),
            num3 = new ComplexNumber(1, 1);

        Console.WriteLine($"Number 1: {num1}. Number 2 {num2}");

        num1 += 1;
        
        Console.WriteLine($"Number 1 after addition 1: {num1}");

        num1.Imagine = 1;
        
        Console.WriteLine($"Number 1 after assignment 1 to imagine part: {num1}");
        
        num2 += num1;
        
        Console.WriteLine($"Number 2 after addition number 1: {num2}");

        Console.WriteLine($"Number 1 equals number 2: {num1.Equals(num2)}");
        Console.WriteLine($"Number 1 equals number 3: {num1.Equals(num3)}");
        Console.WriteLine($"Number 2 equals number 3: {num2.Equals(num3)}");
    }
}