using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class DeleteOrderInputService : IDeleteOrderInputService
{
    private readonly DeliveryOrderDb context;
    public DeleteOrderInputService(DeliveryOrderDb ctx)
    {
        context = ctx;
    }
    public async Task<bool> DeleteOrderAsync(DeleteOrderData data)
    {
        int id = data.Id;
        Order order = context.Orders.FirstOrDefault(p => p.OrderId == id);
        if (order != null)
        {
            context.Orders.Remove(order);
            context.SaveChanges();
        }
        return true;
    }    
}

