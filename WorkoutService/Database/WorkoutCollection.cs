using MongoDB.Driver;
using WorkoutService.Models;

namespace WorkoutService.Database;

public class WorkoutCollection
{
    
    private readonly IMongoCollection<WorkoutIntensity> _workout;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkoutCollection"/> class.
    /// </summary>
    public WorkoutCollection()
    {
        // Connect to the MongoDB database
        var connectionString = "mongodb+srv://rasm92i3:flaskebong420@cluster0.te79kwa.mongodb.net/";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("WorkoutServiceDB");

        // Initialize the collection for users
        _workout = database.GetCollection<WorkoutIntensity>("WorkoutCollection");
    }

    /// <summary>
    /// Retrieves the workout intensity for a user by their ID.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>The <see cref="WorkoutIntensity"/> object representing the workout intensity.</returns>
    public WorkoutIntensity GetWorkOutIntensity(int userId)
    {
        var workout = _workout.Find<WorkoutIntensity>(workout => workout.UserId == userId).FirstOrDefault();
        return workout;

    }

    /// <summary>
    /// Sets the workout intensity for a user.
    /// </summary>
    /// <param name="workoutIntensity">The <see cref="WorkoutIntensity"/> object representing the workout intensity.</param>
    public void SetWorkOutIntensity(WorkoutIntensity workoutIntensity)
    {
        var oldWorkout = GetWorkOutIntensity(workoutIntensity.UserId);
        oldWorkout.UserId = workoutIntensity.UserId;
        oldWorkout.WorkoutId = workoutIntensity.WorkoutId;
        oldWorkout.WorkOutIntensity = workoutIntensity.WorkOutIntensity;
        _workout.DeleteOne(w => w.UserId == oldWorkout.UserId);
        _workout.InsertOne(oldWorkout);

    }

    /// <summary>
    /// Adds a new workout intensity record.
    /// </summary>
    /// <param name="workoutIntensity">The <see cref="WorkoutIntensity"/> object representing the workout intensity.</param>
    public void AddWorkoutIntensity(WorkoutIntensity workoutIntensity)
    {
        _workout.InsertOne(workoutIntensity);
    }
    
}