namespace NutritionService.Models;


public class Meal
{
    /// <summary>
    /// Gets or sets the name of the meal.
    /// </summary>
    public string MealName { get; set; }

    /// <summary>
    /// Represents the type of the meal.
    /// </summary>
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner
    }

    /// <summary>
    /// Gets or sets the number of calories in the meal.
    /// </summary>
    public double MealCalories { get; set; }
}