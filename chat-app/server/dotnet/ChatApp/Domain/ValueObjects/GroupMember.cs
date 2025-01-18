using SecurityDriven;

namespace Domain.ValueObjects;
public sealed class GroupMember
{
    private GroupMember(
        Guid groupId,
        Guid userId,
        DateTime? joinedAt,
        string status)
    {
        GroupId = groupId;
        UserId = userId;
        JoinedAt = joinedAt;
        Status = status;
    }

    public Guid Id { get; set; }

    public Guid GroupId { get; set; }

    public Guid UserId { get; set; }

    public DateTime? JoinedAt { get; set; }

    public string Status { get; set; }

    public static GroupMember Create(
                        Guid groupId,
                        Guid userId,
                        DateTime? joinedAt,
                        string status)
    {
        var groupMember = new GroupMember(
                                groupId,
                                userId, 
                                joinedAt, 
                                status)
        {
            Id = FastGuid.NewGuid()
        };
        return groupMember;
    }
}
