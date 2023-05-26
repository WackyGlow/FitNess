using Common;
using EasyNetQ;
using UserService.Models;

namespace UserService.Infrastructure
{
    /// <summary>
    /// Represents a message publisher for user-related messages.
    /// </summary>
    public class UserMessagePublisher : IUserMessagePublisher, IDisposable
    {
        private IBus bus;

        /// <summary>
        /// Initializes a new instance of the UserMessagePublisher class with the specified RabbitMQ connection string.
        /// </summary>
        /// <param name="connectionString">The RabbitMQ connection string.</param>
        public UserMessagePublisher(string connectionString)
        {
            bus = RabbitHutch.CreateBus(connectionString);
        }

        /// <summary>
        /// Releases the resources used by the UserMessagePublisher object.
        /// </summary>
        public void Dispose()
        {
            bus.Dispose();
        }

        /// <summary>
        /// Publishes a calorie intake created message for the specified user.
        /// </summary>
        /// <param name="user">The user for which the calorie intake message is published.</param>
        public void PublishCalorieIntakeCreatedMessage(User user)
        {
            var message = new UserDataMessage
            {
                Id = user.Id,
                Age = user.Age,
                Sex = user.Sex,
                Weight = user.Weight,
                KgLossPerWeek = user.WeightLossPerWeek,
                Height = user.Height

            };

            // Publish the message to the "userCalorieIntake" topic exchange
            bus.PubSub.Publish(message, "userCalorieIntake");
        }

    }
}
