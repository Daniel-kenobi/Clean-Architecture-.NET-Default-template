namespace CleanArch.Domain.Commons.Pagination;

public class Pagination<T> where T : class
{
    public IQueryable<T> Paginate(IQueryable<T> query, IPaginatedRequest request)
    {
        if (!Pagination<T>.IsPaginatedRequest(request))
            return query;

        if (request.Page > 1)
            return query.Skip((request.Page - 1) * request.Fetch).Take(request.Fetch);

        return query.Take(request.Fetch);
    }

    private static bool IsPaginatedRequest(object request) => 
        request is IPaginatedRequest;
}
