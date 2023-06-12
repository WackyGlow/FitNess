namespace UserService.Models;

/// <summary>
/// Represents a user in the fitness app.
/// </summary>
public class User
{
    /// <summary>
    /// Gets or sets the ID of the user.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Gets or sets the age of the user.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Gets or sets the sex of the user.
    /// </summary>
    public string? Sex { get; set; }

    /// <summary>
    /// Gets or sets the weight of the user.
    /// </summary>
    public double Weight { get; set; }

    /// <summary>
    /// Gets or sets the desired weight of the user.
    /// </summary>
    public double DesiredWeight { get; set; }

    /// <summary>
    /// Gets or sets the height of the user.
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// Gets or sets the weight loss per week of the user.
    /// </summary>
    public double WeightLossPerWeek { get; set; }
}