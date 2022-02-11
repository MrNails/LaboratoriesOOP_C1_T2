using System;
using OOP_Labs_C1_T2.Lab5.Vegetables;

namespace OOP_Labs_C1_T2.Lab5;

public class Lab5 : IExecutable
{
    private Salad m_salad;

    public Lab5()
    {
        m_salad = new Salad();
    }

    public void Execute()
    {
        Console.WriteLine("Laboratory work 5");

        m_salad.Vegetables.Add(new Cucumber());
        m_salad.Vegetables.Add(new Cucumber(150.423f));
        m_salad.Vegetables.Add(new Tomato(137));
        m_salad.Vegetables.Add(new Tomato(250));
        m_salad.Vegetables.Add(new Onion(116.44f));

        Console.WriteLine("Salad info.\nVegetables:");
        foreach (var vegetable in m_salad.Vegetables)
        {
            Console.WriteLine(vegetable.ToString());
            Console.WriteLine("");
        }

        Console.WriteLine($"Salad total calories: {m_salad.GetCalories()}");
    }
}