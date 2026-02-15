using DesignPatternChallengeFactoryMethod.Abstraction;
using DesignPatternChallengeFactoryMethod.ConcreteProducts;

namespace DesignPatternChallengeFactoryMethod.Creators
{
    public class PushNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
