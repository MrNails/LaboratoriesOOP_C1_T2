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
            var factorialClassType = assembly.GetType("DotNetLab2.FactorialClass");

            if (factorialClassType == null)
            {
                Console.WriteLine("FactorialClass type is not exists in assembly DotNetLab2.dll");
                return;
            }
        
            var factorialClassInstance = assembly.CreateInstance("DotNetLab2.FactorialClass");
            var method = factorialClassType.GetMethod("Factorial");
        
            if (method == null)
            {
                Console.WriteLine("Method Factorial is not exists in class FactorialClass");
                return;
            }

            var factorial = method.Invoke(factorialClassInstance, new object[] { num });
            Console.WriteLine(factorial);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}