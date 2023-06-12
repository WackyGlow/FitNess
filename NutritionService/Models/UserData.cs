namespace NutritionService.Models;

public class UserData
{
    /// <summary>
    /// Gets or sets the age of the user.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Gets or sets the sex of the user.
    /// </summary>
    public string Sex { get; set; }

    /// <summary>
    /// Gets or sets the weight of the user.
    /// </summary>
    public double Weight { get; set; }

    /// <summary>
    /// Gets or sets the weight loss per week of the user.
    /// </summary>
    public double KgLossPerWeek { get; set; }

    /// <summary>
    /// Gets or sets the height of the user.
    /// </summary>
    public double Height { get; set; }
}