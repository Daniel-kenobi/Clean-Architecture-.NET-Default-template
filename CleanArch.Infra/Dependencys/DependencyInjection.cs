using CleanArch.Infra.Configs.Maps.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArch.Infra.Dependencys
{
    public static class DependencyInjection
    {
        public static IServiceCollection Inject(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<DefaultMapProfile>());
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return serviceCollection;
        }
    }
}
