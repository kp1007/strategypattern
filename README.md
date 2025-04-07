# Patient Notification System

A flexible C# implementation for managing patient appointment reminders using the Strategy and Factory design patterns.

## Overview

This system allows healthcare providers to send appointment reminders to patients through multiple notification channels (SMS, Email, Push notifications) based on patient preferences.

## Design Patterns Used

| Pattern | Purpose |
|--------|---------|
| **Strategy** | Encapsulates each notification method (SMS, Email, Push) as a strategy |
| **Factory**  | Dynamically creates strategies based on patient preferences |

### Strategy Pattern
- Defines a family of algorithms (notification methods)
- Encapsulates each algorithm (SMS, Email, Push notifications)
- Makes the algorithms interchangeable
- Allows the client to choose which algorithm to use based on patient preferences

### Factory Pattern
- Creates notification strategy objects based on patient preferences
- Centralizes the creation logic
- Makes it easy to add new notification types in the future

## Core Components

### NotificationType (Enum)
Patients can choose any combination of:
- 📩 Email
- 📱 SMS
- 🔔 Push Notifications

 ## Extending the System like ...
To add a new notification type (e.g., WhatsApp):

### INotificationStrategy (Interface)
Contract for all notification strategies with a single method:
```csharp
void Send(string message, Patient patient);
```

### Concrete Strategy Classes
Each implements the `INotificationStrategy` interface:
- `SmsNotification`: Sends SMS messages
- `EmailNotification`: Sends email notifications
- `PushNotification`: Sends push notifications to mobile devices

### Patient Model
Contains patient data and notification preferences:
- Basic details (name, contact information)
- List of preferred notification types

### NotificationFactory
Creates notification strategy objects based on patient preferences:
- Takes a patient object as input
- Examines the notification preferences
- Creates and returns appropriate strategy objects

### ReminderService
High-level service that:
- Uses the factory to create appropriate notification strategies
- Sends the reminder message via all preferred channels

## Usage Example

```csharp
// Create a patient with preferences
var patient = new Patient
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

// Create the reminder service
var reminderService = new ReminderService();

// Send a reminder
reminderService.SendReminder(patient, 
    "Your appointment is scheduled for tomorrow at 10 AM.");
```

## Benefits

1. **Flexibility**: Easily add new notification channels
2. **Patient-Centered**: Respects patient communication preferences
3. **Maintainability**: Clean separation of concerns
4. **Extensibility**: New notification types can be added with minimal changes
5. **Testability**: Components can be tested in isolation

