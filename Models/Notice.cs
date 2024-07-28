namespace Remindoceros2.Models;

public record Notification
{
    public required Guid Id { get; set; }
    public required string Message { get; init; }
    public required IEnumerable<NotificationMethod> notificationMethods { get; set; }
}
