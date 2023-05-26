using NutritionService.Models;

namespace NutritionService.Logic;

class CalorieCalculator
{
    private double activitymodifier;

    /// <summary>
    /// Initializes a new instance of the CalorieCalculator class with the default activity modifier.
    /// </summary>
    public CalorieCalculator()
    {
        activitymodifier = 1.375;
    }

    /// <summary>
    /// Calculates the Basal Metabolic Rate (BMR) using the Harris-Benedict equation.
    /// </summary>
    /// <param name="userData">The user data used for BMR calculation.</param>
    /// <returns>The calculated BMR value.</returns>
    public double CalculateBMR(UserData userData)
    {
        // Harris-Benedict equation for BMR calculation
        double bmr = 66.5 + (13.75 * userData.Weight) + (5 * userData.Height) - (6.75 * userData.Age);
        return bmr;
    }

    /// <summary>
    /// Calculates the daily calorie deficit required for the specified kilograms to lose per week.
    /// </summary>
    /// <param name="kilogramsToLosePerWeek">The number of kilograms to lose per week.</param>
    /// <returns>The calculated daily calorie deficit.</returns>
    public double CalculateCalorieDeficit(double kilogramsToLosePerWeek)
    {
        // Each kilogram of body weight roughly corresponds to 7700 calories
        double calorieDeficitPerDay = (kilogramsToLosePerWeek * 7700) / 7;
        return calorieDeficitPerDay;
    }

    /// <summary>
    /// Calculates the daily calorie intake goal for the specified user data.
    /// </summary>
    /// <param name="userData">The user data used for calorie intake goal calculation.</param>
    /// <returns>The calculated daily calorie intake goal.</returns>
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