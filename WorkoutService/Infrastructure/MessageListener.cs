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

    public MessageListener(IServiceProvider provider, string connectionString)
    {
        _provider = provider;
        _connectionString = connectionString;
        _workoutCollection = new WorkoutCollection();
    }

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

    private void HandleSetWorkoutHandler(SetWorkoutIntensityMessage obj)
    {
        var intensityToAdd = new WorkoutIntensity
        {
            UserId = obj.UserId,
            WorkoutId = new Guid(),
            WorkOutIntensity = obj.WorkOutIntensity
        };
        _workoutCollection.SetWorkOutIntensity(intensityToAdd);
    }
}