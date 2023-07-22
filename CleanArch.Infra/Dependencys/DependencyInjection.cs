using CleanArch.Infra.Configs.Maps.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.Dependencys
{
    public static class DependencyInjection
    {
        public static IServiceCollection Inject(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<DefaultMapProfile>());
            return serviceCollection;
        }
    }
}
