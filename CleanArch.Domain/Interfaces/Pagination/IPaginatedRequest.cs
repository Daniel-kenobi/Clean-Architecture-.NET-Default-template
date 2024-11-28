namespace CleanArch.Domain.Interfaces.Pagination;

public interface IPaginatedRequest
{
    public int Page { get; set; }
    public int Fetch { get; set; }
}
