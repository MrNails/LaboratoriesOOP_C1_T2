namespace OOP_Labs_C1_T2.Lab5.Vegetables;

public class Tomato : Vegetable
{
    private static readonly float s_caloriesPer100Gram = 18;
    
    public Tomato() : this(200)
    {
        
    }
    
    public Tomato(float weight) : base(weight)
    {
    }

    public override float GetCalories()
    {
        return s_caloriesPer100Gram * GetCaloriesMultiplier();
    }
}