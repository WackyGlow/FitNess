using Common;
using EasyNetQ;
using NutritionService.Controllers;

namespace NutritionService.Infrastructure;

public class MessageListener
{
    private IServiceProvider _provider;
    private string _connectionString;

    public MessageListener(IServiceProvider provider, string connectionString)
    {
        _provider = provider;
        _connectionString = connectionString;
    }

    public void start()
    {
        using (var bus = RabbitHutch.CreateBus(_connectionString))
        {
            bus.PubSub.Subscribe<UserDataMessage>("nutritionAPI",HandleUserDataMessage, x => x.WithTopic("userCalorieIntake"));
        }
        lock (this)
        {
            Monitor.Wait(this);
        }
    }

    private void HandleUserDataMessage(UserDataMessage message)
    {
        Console.WriteLine(message);
    }
}