using System.Runtime.InteropServices.JavaScript;

namespace NutritionService.Models;

public class MealList
{
    public DateOnly DateOnly { get; set; }
    private List<Meal> Meals { get; set; }
}