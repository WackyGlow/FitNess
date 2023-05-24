using System.Runtime.InteropServices.JavaScript;

namespace NutritionService.Models;

public class MealList
{
    public DateOnly DateOnly { get; set; }
    public List<Meal> Meals { get; set; }
}