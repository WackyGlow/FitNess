﻿using MongoDB.Driver;
using WorkoutService.Models;

namespace WorkoutService.Database;

public class WorkoutCollection
{
    
    private readonly IMongoCollection<WorkoutIntensity> _workout;

    public WorkoutCollection()
    {
        // Connect to the MongoDB database
        var connectionString = "mongodb+srv://rasm92i3:<P@n1cb0y5>@cluster0.te79kwa.mongodb.net/?retryWrites=true&w=majority";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("WorkoutServiceDB");

        // Initialize the collection for users
        _workout = database.GetCollection<WorkoutIntensity>("WorkoutCollection");
    }
    
    public WorkoutIntensity GetWorkOutIntensity(int userId)
    {
        var workout = _workout.Find<WorkoutIntensity>(workout => workout.UserId == userId).FirstOrDefault();
        return workout;

    }

    public WorkoutIntensity SetWorkOutIntensity(WorkoutIntensity workoutIntensity)
    {
        
    }
    
}