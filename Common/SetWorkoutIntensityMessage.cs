namespace Common;

/// <summary>
/// Represents a message for setting the workout intensity for a user.
/// </summary>
public class SetWorkoutIntensityMessage
{
    /// <summary>
    /// Gets or sets the ID of the user.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the workout intensity for the user.
    /// </summary>
    public int WorkOutIntensity { get; set; }
}