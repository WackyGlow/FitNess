using NutritionService.Models;

namespace NutritionService.Logic;

class CalorieCalculator
{
    private double activitymodifier;

    public CalorieCalculator()
    {
        activitymodifier = 1.375;
    }
    public double CalculateBMR(UserData userData)
    {
        // Harris-Benedict equation for BMR calculation
        double bmr = 66.5 + (13.75 * userData.Weight) + (5 * userData.Height) - (6.75 * userData.Age);
        return bmr;
    }

    public double CalculateCalorieDeficit(double kilogramsToLosePerWeek)
    {
        // Each kilogram of body weight roughly corresponds to 7700 calories
        double calorieDeficitPerDay = (kilogramsToLosePerWeek * 7700) / 7;
        return calorieDeficitPerDay;
    }

    public double CalculateDailyCalorieIntakeGoal(UserData userData)
    {
        double bmr = CalculateBMR(userData);
        double tdee = bmr * activitymodifier;
        double calorieDeficitPerDay = CalculateCalorieDeficit(userData.KgLossPerWeek);
        double calorieIntakeGoal = tdee - calorieDeficitPerDay;
        Console.WriteLine("Calorie Intake Goal is :" + calorieIntakeGoal);
        return calorieIntakeGoal;
    }
}