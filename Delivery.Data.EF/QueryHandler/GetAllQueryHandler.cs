using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;

namespace Delivery.Hex.Core.QueryHandler
{
    public class GetAllQueryHandler : IQueryHandler<GetAllQuery, GetAllQueryModel>
    {
        private readonly DeliveryOrderDb _Context;
        public async Task<GetAllQueryModel> ExecuteAsync(GetAllQuery query)
        {
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
