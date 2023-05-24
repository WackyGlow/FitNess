using Common;
using UserService.Models;

namespace UserService.Infrastructure
{
    public interface IUserMessagePublisher
    {
        void PublishCalorieIntakeCreatedMessage(User user);
    }
}