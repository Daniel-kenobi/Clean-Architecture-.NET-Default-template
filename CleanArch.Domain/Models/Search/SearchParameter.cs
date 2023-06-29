using CleanArch.Domain.Interfaces.Pagination;

namespace CleanArch.Domain.Models.Search
{
    public class SearchParameter : IPaginatedRequest
    {
        public int Page { get; set; } = 1;
        public int Fetch { get; set; } = 50;
        public string? query { get; set; }
        public int Id { get; set; }
    }
}
