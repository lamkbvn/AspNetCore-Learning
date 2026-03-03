using AspNetCore.DependencyInjection.ServiceLifetime;

namespace AspNetCore.DependencyInjection
{
    public static class MyConfigServiceCollectionExtension
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            services.AddScoped<IMyDependency, MyDependency>();
            services.AddScoped<IMyDependency2, MyDependency2>();

            return services;
        }

        public static IServiceCollection AddServiceLifetime(this IServiceCollection services)
        {
            services.AddTransient<ITransientGuid, TransientGuid>();
            services.AddScoped<IScopedGuid, ScopedGuid>();
            services.AddSingleton<ISingletonGuid, SIngletonGuid>();

            return services;
        }
    }
}
