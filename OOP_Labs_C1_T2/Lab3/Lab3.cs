using System;
using System.Text;

namespace OOP_Labs_C1_T2.Lab3;

public class Lab3 : IExecutable
{
    public void Execute()
    {
        var name = string.Empty;
        var surName = string.Empty;
        var patronymic = string.Empty;
        var fullName = string.Empty;
        
        Console.WriteLine("Laboratory work 3");
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        
        Console.Write("Enter surName: ");
        surName = Console.ReadLine();
        
        Console.Write("Enter patronymic: ");
        patronymic = Console.ReadLine();

        Console.WriteLine($"Your full name: {name}({name.Length}) {surName}({surName.Length}) {patronymic}({patronymic.Length})");

        fullName = name + " " + surName;
        
        Console.WriteLine($"Full name in base64: {Convert.ToBase64String(Encoding.UTF8.GetBytes(fullName))}");
    }
}