using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;

namespace Delivery.Data.EF.QueryHandler
{
    /// <summary>
    /// класс-запрос поиск текста в полях заявки
    /// выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class SearchOrderQueryHandler : IQueryHandler<SearchOrderQuery, SearchOrderQueryModel>
    {
        private readonly DeliveryOrderDb _Context;
        public async Task<SearchOrderQueryModel> ExecuteAsync(SearchOrderQuery query)
        {
            _Context.Couriers.ToList();
            _Context.Clients.ToList();
            string text = query.Text;
            List<Order> orders = _Context.Orders.ToList();
            IEnumerable<Order> res = from order in orders
                                     where order.Shipper.Name.ToLower().Contains(text.ToLower())
                                     || order.Consignee.Name.ToLower().Contains(text.ToLower())
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
