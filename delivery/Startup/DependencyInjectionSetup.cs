using System;
using Delivery.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace delivery.Startup
{
	public static class DependencyInjectionSetup
	{
		public static IServiceCollection RegisterDatabaseContext(this IServiceCollection services, IConfiguration configuration)
		{
            services.AddDbContext<DeliveryOrderDb>(options =>
				options.UseSqlServer(
					configuration["Data:DeliveryOrder:ConnectionString"]));

            services.AddTransient<DeliveryOrderDb>();

			return services;
		}

		public static IServiceCollection RegisterDeliveryServices(this IServiceCollection services, IConfiguration configuration)
		{

            return services;
		}

    }
}
