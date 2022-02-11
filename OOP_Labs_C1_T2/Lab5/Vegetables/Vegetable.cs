using System;

namespace OOP_Labs_C1_T2.Lab5.Vegetables;

public abstract class Vegetable : IGetCalories
{
    private float m_weight;

    protected Vegetable(float weight)
    {
        Weight = weight;
    }

    public float Weight
    {
        get => m_weight;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Value cannot be less or equal 0.");
                
            m_weight = value;
        }
    }
    
    public abstract float GetCalories();

    protected float GetCaloriesMultiplier()
    {
        int iWeight = (int)Weight;
        float multiplier = 0.0f;
        float fraction = Weight - iWeight;

        while (iWeight >= 100)
        {
            iWeight -= 100;
            multiplier++;
        }

        multiplier += (iWeight + fraction) / 100.0f;
        
        return multiplier;
    }

    public virtual string ToString()
    {
        return $"\tName: {GetType().Name}\n\tWeight: {Weight}\n\tCalories: {GetCalories()}";
    }
}