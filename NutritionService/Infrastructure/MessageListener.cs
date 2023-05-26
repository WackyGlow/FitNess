using Common;
using EasyNetQ;
using NutritionService.Controllers;

namespace NutritionService.Infrastructure;

public class MessageListener
{
    private IServiceProvider _provider;
    private string _connectionString;
    private IBus _bus;

    public MessageListener(IServiceProvider provider, string connectionString)
    {
        _provider = provider;
        _connectionString = connectionString;
        _bus = RabbitHutch.CreateBus(_connectionString);
    }

    public void start()
    {
        _bus.PubSub.Subscribe<UserDataMessage>("nutritionApiTGUserCalorieIntake",HandleUserDataMessage, x => x.WithTopic("userCalorieIntake"));
   
    }

    private void HandleUserDataMessage(UserDataMessage message)
    {
        // Process the received message
        Console.WriteLine("Received message: ID: " + message.Id + " | Weight: " + message.Weight + " | Height: " + message.Height + " | Age :" + message.Age + " | Sex: " + message.Sex + " | KgLossPerWeek: " + message.KgLossPerWeek);
    }

    public void Dispose()
    {
        // Dispose the bus and close the RabbitMQ connection
        _bus.Dispose();
    }
}