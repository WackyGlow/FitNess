namespace Common;

/// <summary>
/// Represents a message containing user data.
/// </summary>
public class UserDataMessage
{
    /// <summary>
    /// Gets or sets the ID of the user.
    /// </summary>
    public int Id { get; set; }

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
    /// Gets or sets the rate of weight loss per week for the user.
    /// </summary>
    public double KgLossPerWeek { get; set; }

    /// <summary>
    /// Gets or sets the height of the user.
    /// </summary>
    public double Height { get; set; }
}