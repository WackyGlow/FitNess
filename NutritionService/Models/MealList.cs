using System.Runtime.InteropServices.JavaScript;

namespace NutritionService.Models;

public class MealList
{
    /// <summary>
    /// Gets or sets the date of the meal list.
    /// </summary>
    public DateOnly DateOnly { get; set; }

    /// <summary>
    /// Gets or sets the list of meals.
    /// </summary>
    public List<Meal> Meals { get; set; }
}