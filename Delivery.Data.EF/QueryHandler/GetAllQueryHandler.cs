using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;

namespace Delivery.Data.EF.QueryHandler
{
    /// <summary>
    /// класс-запрос получения всех заявок
    /// выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class GetAllQueryHandler : IQueryHandler<GetAllQuery, GetAllQueryModel>
    {
        private readonly DeliveryOrderDb _Context;
        public async Task<GetAllQueryModel> ExecuteAsync(GetAllQuery query)
        {
            _Context.Couriers.ToList();
            _Context.Clients.ToList();
            IEnumerable<Order> orders = _Context.Orders;
            return new GetAllQueryModel()
            {
                Orders = orders
            };
        }
        public GetAllQueryHandler(DeliveryOrderDb context)
        {
            _Context = context;
        }
    }
}
