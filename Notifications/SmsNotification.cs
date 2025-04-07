public class SmsNotification : INotificationStrategy
{
    public void Send(string message, PatientNotification patient)
    {
        Console.WriteLine($"Sending SMS to {patient.PhoneNumber}: {message}");
    }
}
