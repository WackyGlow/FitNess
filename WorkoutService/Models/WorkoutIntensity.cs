namespace WorkoutService.Models;

/// <summary>
/// Represents the intensity of a workout for a user.
/// </summary>
public class WorkoutIntensity
{
    /// <summary>
    /// Gets or sets the unique identifier of the workout.
    /// </summary>
    public Guid WorkoutId { get; set; }

    /// <summary>
    /// Gets or sets the user ID associated with the workout intensity.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the intensity level of the workout.
    /// </summary>
    public int WorkOutIntensity { get; set; }
}