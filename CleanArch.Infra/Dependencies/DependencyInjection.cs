namespace CleanArch.Infra.Dependencies;

public static class DependencyInjection
{
    public static IServiceCollection Inject(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return serviceCollection;
    }
}
