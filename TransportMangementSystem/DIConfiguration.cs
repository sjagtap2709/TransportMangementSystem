using TMSBusinessLogicLayer.Business_Components;
using TMSBusinessLogicLayer.IBusiness_Components;
using TMSDataAccessLayer.DataComponents;
using TMSDataAccessLayer.IDataComponents;

namespace TransportMangementSystem
{
    public static class DIConfiguration
    {
        public static IServiceCollection AddConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserBC, UserBC>();
            services.AddScoped<IUserDC, UserDC>();
            return services;
        }
    }
}
