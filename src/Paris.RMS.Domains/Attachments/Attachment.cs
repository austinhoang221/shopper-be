namespace Paris.RMS.Domains.Attachments;

public sealed class Attachment : EntityBase
{
    private Attachment()
    {

    }

    private Attachment(string fileName, string originName, string link, long size, string categoryType, string ownerId)
    {
        Name = fileName;
        OriginName = originName;
        Type = fileName.GetExtensionFile();
        Link = link;
        Size = size;
        CategoryType = categoryType;
        OwnerId = ownerId;
    }

    public string Name { get; set; } = string.Empty;

    public string OriginName { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Link { get; set; } = string.Empty;

    public long Size { get; set; }

    public string CategoryType { get; set; } = string.Empty;

    public string OwnerId { get; set; } = string.Empty;

    public static Attachment Create(
        string fileName,
        string originName,
        string link,
        long size,
        string categoryType,
        string ownerId)
        => new(fileName, originName, link, size, categoryType, ownerId);
}
