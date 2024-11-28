namespace CleanArch.Infra.Repository;

public interface IRepository<T> where T : class
{
    public Task Create(T entity);
    public Task<IList<T>> Get(IPaginatedRequest request);
    public Task Update(T entity);
    public Task Delete(int id);
}
