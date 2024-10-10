namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.OffsetPages;

public sealed class OffsetPageException(int currentPage, int totalPages)
    : BadRequestException($"Selected page '{currentPage}' is greater than total number of pages '{totalPages}'")
{
}
