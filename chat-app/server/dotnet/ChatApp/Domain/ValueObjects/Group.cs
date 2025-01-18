using SecurityDriven;

namespace Domain.ValueObjects;
public sealed class Group
{
    private Group(
            string name,
            Guid createdBy,
            int totalMembers
        )
    {
        Name = name;
        CreatedBy = createdBy;
        TotalMembers = totalMembers;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public Guid CreatedBy { get; set; }

    public int TotalMembers { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public static Group Create(
        string name,
        Guid createdBy,
        int totalMembers
    )
    {
        var group = new Group(
                            name,
                            createdBy, 
                            totalMembers)
        {
            Id = FastGuid.NewGuid()
        };
        return group;
    }
}
