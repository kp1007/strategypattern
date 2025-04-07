public class ReminderService
{
    public void SendReminder(PatientNotification patient, string message)
    {
        var strategies = NotificationFactory.CreateStrategies(patient);

        foreach (var strategy in strategies)
        {
            strategy.Send(message, patient);
        }
    }
}