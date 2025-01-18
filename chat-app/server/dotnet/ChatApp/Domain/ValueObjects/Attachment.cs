using SecurityDriven;

namespace Domain.ValueObjects;
public sealed class Attachment
{
    private Attachment(
        Guid messageId,
        string fileUrl,
        string fileType,
        int fileSize,
        string directory)
    {
        MessageId = messageId;
        FileUrl = fileUrl;
        FileType = fileType;
        FileSize = fileSize;
        Directory = directory;
    }
    public Guid Id { get; set; }

    public Guid MessageId { get; set; }

    public string FileUrl { get; set; }

    public string FileType { get; set; }

    public int FileSize { get; set; }

    public string Directory { get; set; }

    public static Attachment Create(
                            Guid messageId,
                            string fileUrl,
                            string fileType,
                            int fileSize,
                            string directory)
    {
        var attachment = new Attachment(
                            messageId,
                            fileUrl,
                            fileType,
                            fileSize,
                            directory)
        {
            Id = FastGuid.NewGuid()
        };

        return attachment;
    }
}
