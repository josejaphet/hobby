using SecurityDriven;

namespace Domain.ValueObjects;
public class Message
{
    private Message(
        Guid senderId,
        Guid receiverId,
        Guid? groupId,
        string content,
        List<string> types,
        string status)
    {
        SenderId = senderId;
        ReceiverId = receiverId;
        GroupId = groupId;
        Content = content;
        Type = types;
        Status = status;
    }
    public Guid Id { get; private set; }

    public Guid SenderId { get; private set; }

    public Guid ReceiverId { get; private set; }

    public Guid? GroupId { get; private set; }

    public string Content { get; private set; }

    public List<string> Type { get; private set; }

    public string Status { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public static Message Create(
        Guid senderId,
        Guid receiverId,
        Guid? groupId,
        string content,
        List<string> types,
        string status)
    {
        var message = new Message(
                            senderId,
                            receiverId,
                            groupId,
                            content,
                            types,
                            status)
        {
            Id = FastGuid.NewGuid()
        };
        return message;
    }
}
