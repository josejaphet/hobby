using SecurityDriven;

namespace Domain.ValueObjects;
public sealed class Notification
{
    private Notification(
        Guid userId,
        Guid receiverId,
        string content,
        string type,
        string status)
    {
        UserId = userId;
        ReceiverId = receiverId;
        Content = content;
        Type = type;
        Status = status;
    }

    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid ReceiverId { get; set; }

    public string Content { get; set; }

    public string Type { get; set; }

    public string Status { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public static Notification Create(
        Guid userId,
        Guid receiverId,
        string content,
        string type,
        string status)
    {
        var notification = new Notification(
                                        userId,
                                        receiverId,
                                        content,
                                        type,
                                        status)
        {
            Id = FastGuid.NewGuid()
        };

        return notification;
    }
}
