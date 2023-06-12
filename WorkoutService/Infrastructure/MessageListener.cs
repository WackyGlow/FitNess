using Common;
using EasyNetQ;
using WorkoutService.Database;
using WorkoutService.Models;

namespace WorkoutService.Infrastructure;

public class MessageListener
{
    private IServiceProvider _provider;
    private string _connectionString;
    private WorkoutCollection _workoutCollection;

    /// <summary>
    /// Initializes a new instance of the <see cref="MessageListener"/> class.
    /// </summary>
    /// <param name="provider">The <see cref="IServiceProvider"/> for dependency injection.</param>
    /// <param name="connectionString">The RabbitMQ connection string.</param>
    public MessageListener(IServiceProvider provider, string connectionString)
    {
        _provider = provider;
        _connectionString = connectionString;
        _workoutCollection = new WorkoutCollection();
    }

    /// <summary>
    /// Starts listening for messages from RabbitMQ.
    /// </summary>
    public void start()
    {
        using (var bus = RabbitHutch.CreateBus(_connectionString))
        {
            //bus.PubSub.Subscribe<UserDataMessage>("nutritionAPI",HandleUserDataMessage, x => x.WithTopic("userCalorieIntake"));
            bus.PubSub.Subscribe<SetWorkoutIntensityMessage>("workoutAPI", HandleSetWorkoutHandler,
                x => x.WithTopic("setUserIntensity"));
        }
        lock (this)
        {
            Monitor.Wait(this);
        }
    }

    /// <summary>
    /// Handles the SetWorkoutIntensityMessage and sets the workout intensity for a user.
    /// </summary>
    /// <param name="obj">The SetWorkoutIntensityMessage containing the workout intensity information.</param>
    private void HandleSetWorkoutHandler(SetWorkoutIntensityMessage obj)
    {
        // Create a new WorkoutIntensity object with the received data
        var intensityToAdd = new WorkoutIntensity
        {
            UserId = obj.UserId,
            WorkoutId = new Guid(),
            WorkOutIntensity = obj.WorkOutIntensity
        };

        // Set the workout intensity in the WorkoutCollection
        _workoutCollection.SetWorkOutIntensity(intensityToAdd);
    }
}