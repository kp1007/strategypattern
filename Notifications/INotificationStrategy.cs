public interface INotificationStrategy
{
    void Send(string message, PatientNotification patientNotification);
}
