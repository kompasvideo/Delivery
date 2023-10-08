using Delivery.Data.EF;
using Delivery.Data.EF.CommandHandler;
using Delivery.Data.EF.QueryHandler;
using Delivery.Hex.Core;
using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;
using Delivery.Hex.Domain.Services;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.EntityFrameworkCore;

namespace DeliveryServer.Startup
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
            services.AddTransient<InputHandler<AddOrderInputRequest, bool>, AddOrderInputHandler>();
            services.AddTransient<InputHandler<GetAllOrderInputRequest, IEnumerable<object>>, GetAllOrderInputHandler>();
            services.AddTransient<InputHandler<SearchOrderInputRequest, IEnumerable<object>>, SearchOrderInputHandler>();
            services.AddTransient<InputHandler<GetOrderInputRequest, object>, GetOrderInputHandler>();
            services.AddTransient<InputHandler<EditOrderInputRequest, bool>, EditOrderInputHandler>();
            services.AddTransient<InputHandler<DeleteOrderInputRequest, bool>, DeleteOrderInputHandler>();

            services.AddTransient<IAddOrderInputService, AddOrderInputService>();
            services.AddTransient<IGetAllOrderInputService, GetAllOrderInputService>();
            services.AddTransient<ISearchOrderInputService, SearchOrderInputService>();
            services.AddTransient<IGetOrderInputService, GetOrderInputService>();
            services.AddTransient<IEditOrderInputService, EditOrderInputService>();
            services.AddTransient<IDeleteOrderInputService, DeleteOrderInputService>();

            services.AddTransient<ICommandHandler<AddOrderCommand, bool>, AddOrderCommandHandler>();
            services.AddTransient<ICommandHandler<DeleteOrderCommand, bool>, DeleteOrderCommandHandler>();
            services.AddTransient<ICommandHandler<EditOrderCommand, bool>, EditOrderCommandHandler>();
            services.AddTransient<IQueryHandler<GetAllQuery, GetAllQueryModel>, GetAllQueryHandler>();
            services.AddTransient<IQueryHandler<GetOrderQuery, GetOrderQueryModel>, GetOrderQueryHandler>();
            services.AddTransient<IQueryHandler<SearchOrderQuery, SearchOrderQueryModel>, SearchOrderQueryHandler>();
            return services;
        }

    }
}
