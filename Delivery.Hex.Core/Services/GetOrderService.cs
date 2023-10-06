using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Data;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class GetOrderInputService : IGetOrderInputService
{
    private readonly DeliveryOrderDb context;
    public GetOrderInputService(DeliveryOrderDb ctx)
    {
        context = ctx;
    }
    public async Task<object> GetOrderAsync(GetOrderData data)
    {
        int id = data.Id;
        Order order = context.Orders.FirstOrDefault(o => o.OrderId == id);
        return order;
    }
}

