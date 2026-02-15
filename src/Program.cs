using DesignPatternChallengeFactoryMethod.Creators;

namespace DesignPatternChallengeFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações com Factory Method ===\n");

            SendEmailNotification();
            SendSMSNotification();
            SendPushNotification();
            SendWhatsAppNotification();
        }

        public static void SendEmailNotification()
        {
            Console.WriteLine("--- Cliente 1: Notificações por Email ---");
            NotificationCreator emailCreator = new EmailNotificationCreator();
            emailCreator.SendOrderConfirmation("cliente@email.com", "12345");
            EndMessaage();
        }

        public static void SendSMSNotification()
        {
            Console.WriteLine("--- Cliente 2: Notificações por SMS ---");
            NotificationCreator smsCreator = new SmsNotificationCreator();
            smsCreator.SendOrderConfirmation("+5511999999999", "12346");
            EndMessaage();
        }

        public static void SendPushNotification()
        {
            Console.WriteLine("--- Cliente 3: Notificações por Push ---");
            NotificationCreator pushCreator = new PushNotificationCreator();
            pushCreator.SendShippingUpdate("device-token-abc123", "BR123456789");
            EndMessaage();
        }

        public static void SendWhatsAppNotification()
        {
            Console.WriteLine("--- Cliente : Notificações por WhatsApp ---");
            NotificationCreator WhatsApppushCreator = new WhatsAppNotificationCreator();
            WhatsApppushCreator.SendPaymentReminder("+5511888888888", 150.00m);
            EndMessaage();
        }

        public static void EndMessaage()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------\n");
        }
    }
}