using DesignPatternChallengeFactoryMethod.Abstraction;
using DesignPatternChallengeFactoryMethod.ConcreteProducts;

namespace DesignPatternChallengeFactoryMethod.Creators
{
    internal class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}
