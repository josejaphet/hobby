using SecurityDriven;

namespace Domain.ValueObjects;
public sealed class Friend
{
    private Friend(
            Guid userId,
            Guid friendId,
            string status)
    {
        UserId = userId;
        FriendId = friendId;
        Status = status;
    }
    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public Guid FriendId { get; private set; }

    public string Status { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public DateTime? UpdatedOn { get; private set; }

    public static Friend Create(
        Guid userId,
        Guid friendId,
        string status)
    {
        var friend = new Friend(
                            userId, 
                            friendId, 
                            status)
        {
            Id = FastGuid.NewGuid()
        };
        return friend;
    }
}
