public class EmailNotification : INotificationStrategy
{
    public void Send(string message, PatientNotification patient)
    {
        Console.WriteLine($"Sending Email to {patient.Email}: {message}");
    }
}
