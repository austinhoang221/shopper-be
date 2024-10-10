namespace Paris.RMS.UseCases.Attachments;

public sealed class AttachmentResponse(Ulid id, string fileName, string originName, string link, long size, string categoryType, string ownerId)
{
    public Ulid Id { get; } = id;
    public string FileName { get; } = fileName;
    public string OriginName { get; } = originName;
    public string Link { get; } = link;
    public long Size { get; } = size;
    public string CategoryType { get; } = categoryType;
    public string OwnerId { get; } = ownerId;
}
