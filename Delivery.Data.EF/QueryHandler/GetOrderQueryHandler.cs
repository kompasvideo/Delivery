using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;

namespace Delivery.Data.EF.QueryHandler
{
    public class GetOrderQueryHandler : IQueryHandler<GetOrderQuery, GetOrderQueryModel>
    {
        private readonly DeliveryOrderDb _Context;
        public async Task<GetOrderQueryModel> ExecuteAsync(GetOrderQuery query)
        {
            int id = query.Id;
            Order order = _Context.Orders.FirstOrDefault(o => o.OrderId == id);
            return new GetOrderQueryModel()
            {
                Order = order
            };
        }

        public GetOrderQueryHandler(DeliveryOrderDb context)
        {
            _Context = context;
        }
    }
}
