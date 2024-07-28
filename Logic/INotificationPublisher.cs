using Remindoceros2.Models;

namespace Remindoceros2.Logic;

public interface INotificationPublisher
{
    public void Publish(Notification notification);
}
