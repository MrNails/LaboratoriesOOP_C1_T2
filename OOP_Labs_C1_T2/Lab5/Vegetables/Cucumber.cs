namespace OOP_Labs_C1_T2.Lab5.Vegetables;

public class Cucumber : Vegetable
{
    private static readonly float s_caloriesPer100Gram = 15;

    public Cucumber() : this(201) { }
    
    public Cucumber(float weight) : base(weight) { }

    public override float GetCalories()
    {
        return s_caloriesPer100Gram * GetCaloriesMultiplier();
    }
}