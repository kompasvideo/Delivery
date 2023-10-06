using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class GetAllOrderInputService : IGetAllOrderInputService
{
    private readonly DeliveryOrderDb context;
    public GetAllOrderInputService(DeliveryOrderDb ctx)
    {
        context = ctx;
    }
    public async Task<IEnumerable<object>> GetAllOrderAsync(GetAllOrderData data)
    {
        IEnumerable<Order> orders = context.Orders;
        return orders;
    }    
}

