using DotNetLabs.Lab1.Models;
using OOP_Labs_C1_T2.Core;

namespace DotNetLabs.Lab1;

public sealed class Lab1 : IExecutable
{
    public void Execute()
    {
        var bodies = new Body[]
        {
            new Sphere { Radius = 10 },
            new Parallelepiped { Width = 4, Height = 5, Length = 6 },
            new Tetrahedron { Side = 5 }
        };

        for (int i = 0; i < bodies.Length; i++)
        {
            var body = bodies[i];

            Console.WriteLine("{0}. Area: {1}, Volume: {2}", body.GetType().Name, body.Area(), body.Volume());
        }
    }
}