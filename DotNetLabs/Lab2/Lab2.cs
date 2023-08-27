using System.Reflection;
using OOP_Labs_C1_T2.Core;

namespace DotNetLabs.Lab2;

public class Lab2 : IExecutable
{
    public void Execute()
    {
        Console.WriteLine("Input integer value for integral evaluate: ");
        var sNum = Console.ReadLine();

        if (!int.TryParse(sNum, out var num))
        {
            Console.WriteLine("Wrong number");
            return;
        }

        try
        {
            var assembly = Assembly.LoadFrom("DotNetLab2.dll");
            var DynamicClassType = assembly.GetType("DotNetLab2.DynamicClass");

            if (DynamicClassType == null)
            {
                Console.WriteLine("DynamicClass type is not exists in assembly DotNetLab2.dll");
                return;
            }
        
            var DynamicClassInstance = assembly.CreateInstance("DotNetLab2.DynamicClass");
            var factorialMethod = DynamicClassType.GetMethod("Factorial");
        
            if (factorialMethod == null)
            {
                Console.WriteLine("Method Factorial is not exists in class DynamicClass");
                return;
            }

            var factorial = factorialMethod.Invoke(DynamicClassInstance, new object[] { num });
            Console.WriteLine(factorial);

            var triangleAreMethod = DynamicClassType.GetMethod("TriangleArea");

            if (triangleAreMethod == null)
            {
                Console.WriteLine("Method Factorial is not exists in class DynamicClass");
                return;
            }

            var triangleArea = triangleAreMethod.Invoke(DynamicClassInstance, new object[] { 3, 4, 5 });
            Console.WriteLine("Triangle (3,4,5) area is {0}", triangleArea);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}