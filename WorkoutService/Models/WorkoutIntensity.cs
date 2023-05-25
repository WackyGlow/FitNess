namespace WorkoutService.Models;

public class WorkoutIntensity
{
    public Guid WorkoutId { get; set; }
    public int UserId { get; set; }
    public int WorkOutIntensity { get; set; }
}