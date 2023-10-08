using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;

namespace Delivery.Hex.Core.QueryHandler
{
    public class SearchOrderQueryHandler : IQueryHandler<SearchOrderQuery, SearchOrderQueryModel>
    {
        private readonly DeliveryOrderDb _Context;
        public async Task<SearchOrderQueryModel> ExecuteAsync(SearchOrderQuery query)
        {
            string text = query.Text;
            List<Order> orders = _Context.Orders.ToList();
            IEnumerable<Order> res = from order in orders
                                     where order.Shipper.ToLower().Contains(text.ToLower())
                                        || order.Consignee.ToLower().Contains(text.ToLower())
                                        || order.Cargo.ToLower().Contains(text.ToLower())
                                     select order;
            return new SearchOrderQueryModel()
            {
                Orders = res
            };
        }
        public SearchOrderQueryHandler(DeliveryOrderDb context)
        {
            _Context = context;
        }
    }
}
