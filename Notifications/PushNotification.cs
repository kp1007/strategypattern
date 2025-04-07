public class PushNotification : INotificationStrategy
{
    public void Send(string message, PatientNotification patient)
    {
        Console.WriteLine($"Sending Push Notification to {patient.DeviceToken}: {message}");
    }
}
