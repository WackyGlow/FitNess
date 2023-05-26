using Common;
using EasyNetQ;
using NutritionService.Controllers;

namespace NutritionService.Infrastructure;

/// <summary>
/// Represents a message listener for receiving user data messages.
/// </summary>
public class MessageListener
{
    private IServiceProvider _provider;
    private string _connectionString;
    private IBus _bus;

    /// <summary>
    /// Initializes a new instance of the MessageListener class with the specified service provider and RabbitMQ connection string.
    /// </summary>
    /// <param name="provider">The service provider used for dependency injection.</param>
    /// <param name="connectionString">The RabbitMQ connection string.</param>
    public MessageListener(IServiceProvider provider, string connectionString)
    {
        _provider = provider;
        _connectionString = connectionString;
        _bus = RabbitHutch.CreateBus(_connectionString);
    }

    /// <summary>
    /// Starts listening for user data messages.
    /// </summary>
    public void start()
    {
        _bus.PubSub.Subscribe<UserDataMessage>("nutritionApiTGUserCalorieIntake",HandleUserDataMessage, x => x.WithTopic("userCalorieIntake"));
   
    }

    private void HandleUserDataMessage(UserDataMessage message)
    {
        // Process the received message
        Console.WriteLine("Received message: ID: " + message.Id + " | Weight: " + message.Weight + " | Height: " + message.Height + " | Age :" + message.Age + " | Sex: " + message.Sex + " | KgLossPerWeek: " + message.KgLossPerWeek);
    }

    /// <summary>
    /// Releases the resources used by the MessageListener object.
    /// </summary>
    public void Dispose()
    {
        // Dispose the bus and close the RabbitMQ connection
        _bus.Dispose();
    }
}