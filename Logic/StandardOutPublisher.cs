using Remindoceros2.Models;

namespace Remindoceros2.Logic;

public class StandardOutPublisher : INotificationPublisher
{
    public void Publish(Notification notification)
    {
        Console.WriteLine(notification.Message);
    }
}
