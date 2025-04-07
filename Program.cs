class Program
{
    static void Main(string[] args)
    {
        var patient = new PatientNotification
        {
            Name = "Rahul Sharma",
            PhoneNumber = "9876543210",
            Email = "rahul@example.com",
            DeviceToken = "abc123xyz",
            NotificationPreferences = new List<NotificationType>
            {
                NotificationType.SMS,
                NotificationType.Email,
                NotificationType.Push
            }
        };

        var reminderService = new ReminderService();
        reminderService.SendReminder(patient, "Your appointment is scheduled for tomorrow at 10 AM.");

        Console.ReadLine();
    }
}