public class NotificationFactory
{
    public static List<INotificationStrategy> CreateStrategies(PatientNotification patient)
    {
        var strategies = new List<INotificationStrategy>();

        foreach (var type in patient.NotificationPreferences)
        {
            switch (type)
            {
                case NotificationType.SMS:
                    strategies.Add(new SmsNotification());
                    break;
                case NotificationType.Email:
                    strategies.Add(new EmailNotification());
                    break;
                case NotificationType.Push:
                    strategies.Add(new PushNotification());
                    break;
            }
        }

        return strategies;
    }
}
