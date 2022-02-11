namespace OOP_Labs_C1_T2.Lab5.Vegetables;

public class Onion : Vegetable
{
    private static readonly float s_caloriesPer100Gram = 40;

    public Onion() : this(125)
    { }

    public Onion(float weight) : base(weight)
    { }
    
    public override float GetCalories()
    {
        return s_caloriesPer100Gram * GetCaloriesMultiplier();
    }
}