namespace NutritionService.Models;

public class Meal
{
    public string MealName { get; set; }
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner
    }
    public double MealCalories { get; set; }
}