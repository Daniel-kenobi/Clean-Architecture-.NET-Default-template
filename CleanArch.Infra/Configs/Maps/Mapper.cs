namespace CleanArch.Infra.Configs.Maps;

public class Mapper(IMapper mapper)
{
    private readonly IMapper _mapper = mapper;

    public TDestination Map<TDestination>(object source)
    {
        return _mapper.Map<TDestination>(source);
    }
}
