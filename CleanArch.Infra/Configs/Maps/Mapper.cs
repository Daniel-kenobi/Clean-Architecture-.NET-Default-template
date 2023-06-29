using AutoMapper;

namespace CleanArch.Infra.Configs.Maps
{
    public class Mapper
    {
        private readonly IMapper _mapper;
        public Mapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}
