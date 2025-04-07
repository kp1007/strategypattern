public class PatientNotification
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string DeviceToken { get; set; }

    public List<NotificationType> NotificationPreferences { get; set; }
}


public enum NotificationType
{
    SMS,
    Email,
    Push
}
