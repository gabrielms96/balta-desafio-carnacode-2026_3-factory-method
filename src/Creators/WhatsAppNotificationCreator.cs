using DesignPatternChallengeFactoryMethod.Abstraction;
using DesignPatternChallengeFactoryMethod.ConcreteProducts;

namespace DesignPatternChallengeFactoryMethod.Creators
{
    public class WhatsAppNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new WhatsAppNotification();
        }
    }
}
