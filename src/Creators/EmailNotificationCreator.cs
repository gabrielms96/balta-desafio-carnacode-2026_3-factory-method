using DesignPatternChallengeFactoryMethod.Abstraction;
using DesignPatternChallengeFactoryMethod.ConcreteProducts;

namespace DesignPatternChallengeFactoryMethod.Creators
{
    public class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
