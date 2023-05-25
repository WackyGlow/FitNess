using Common;
using EasyNetQ;
using UserService.Models;

namespace UserService.Infrastructure
{
    public class MessagePublisher
    {
        public class UserMessagePublisher : IUserMessagePublisher, IDisposable
        {
            IBus bus;

            public UserMessagePublisher(string connectionString)
            {
                bus = RabbitHutch.CreateBus(connectionString);
            }

            public void Dispose()
            {
                bus.Dispose();
            }

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

                bus.PubSub.Publish(message, "userCalorieIntake");
            }

        }
    }
}
