using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class SearchOrderInputService : ISearchOrderInputService
{
    private readonly DeliveryOrderDb context;
    public SearchOrderInputService(DeliveryOrderDb ctx)
    {
        context = ctx;
    }
    public async Task<IEnumerable<object>> SearchOrderAsync(SearchOrderData data)
    {
        string text = data.Text;
        List<Order> orders = context.Orders.ToList();
        IEnumerable<Order> res = from order in orders
                                 where order.Shipper.ToLower().Contains(text.ToLower())
                                    || order.Consignee.ToLower().Contains(text.ToLower())
                                    || order.Cargo.ToLower().Contains(text.ToLower())
                                 select order;
        return res;
    }
}

