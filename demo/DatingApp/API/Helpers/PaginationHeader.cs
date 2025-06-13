namespace API.Helpers;

public class PaginationHeader(int currentPage, int itemsPerPage, int totalItems, int totalPages)
{
    public int currentPage { get; set; } = currentPage;

    public int ItemsPerPage { get; set; } = itemsPerPage;

    public int TotalItems { get; set; } = totalItems;

    public int totalPages { get; set; } = totalPages;

}