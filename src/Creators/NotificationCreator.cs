using DesignPatternChallengeFactoryMethod.Abstraction;

namespace DesignPatternChallengeFactoryMethod.Creators
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            try
            {
                var notification = CreateNotification();

                ConfigureNotification(notification, recipient,
                "Confirmação de Pedido",
                $"Seu pedido {orderNumber} foi confirmado!");

                notification.Send();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro ao enviar notificação: {ex.Message}");
            }
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            try
            {
                var notification = CreateNotification();
                ConfigureNotification(notification, recipient,
                "Pedido Enviado",
                $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}");
                notification.Send();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro ao enviar notificação: {ex.Message}");
            }
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            try
            {
                var notification = CreateNotification();
                ConfigureNotification(notification, recipient,
                    "Lembrete de Pagamento", $"Pagamento pendente: R$ {amount:N2}");
                notification.Send();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Erro ao enviar notificação: {e.Message}");
            }
        }


        private void ConfigureNotification(INotification notification, string recipient,
            string subject, string message)
        {
            switch (notification)
            {
                case ConcreteProducts.EmailNotification email:
                    email.Recipient = recipient;
                    email.Subject = subject;
                    email.Body = message;
                    email.IsHtml = true;
                    break;

                case ConcreteProducts.SmsNotification sms:
                    sms.PhoneNumber = recipient;
                    sms.Message = message;
                    break;

                case ConcreteProducts.PushNotification push:
                    push.DeviceToken = recipient;
                    push.Title = subject;
                    push.Message = message;
                    push.Badge = 1;
                    break;

                case ConcreteProducts.WhatsAppNotification whatsapp:
                    whatsapp.PhoneNumber = recipient;
                    whatsapp.Message = $"{message}";
                    whatsapp.UseTemplate = true;
                    break;
            }
        }
    }
}
