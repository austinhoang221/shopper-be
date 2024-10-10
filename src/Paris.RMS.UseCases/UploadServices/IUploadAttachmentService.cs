namespace Paris.RMS.UseCases.UploadServices;

public interface IUploadAttachmentService
{
    Task UploadAttachments();

    Task DeleteAttachments();
}
