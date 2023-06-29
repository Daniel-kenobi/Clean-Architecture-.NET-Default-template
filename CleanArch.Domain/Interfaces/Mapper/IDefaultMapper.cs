namespace CleanArch.Domain.Interfaces.Mapper
{
    public interface IDefaultMapper
    {
        public TSource Map<TSource>(object source);
    }
}
