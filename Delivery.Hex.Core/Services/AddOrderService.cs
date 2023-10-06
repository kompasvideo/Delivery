using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class AddOrderInputService : IAddOrderInputService
{
    private readonly DeliveryOrderDb context;
    public AddOrderInputService(DeliveryOrderDb ctx)
    {
        context = ctx;
    }
    public async Task<bool> AddOrderAsync(AddOrderData data)
    {
        Order order = new Order()
        {
            OrderId = data.OrderId,
            Date = data.Date,
            Shipper = data.Shipper,
            Consignee = data.Consignee,
            Cargo = data.Cargo,
            NewOrder = data.NewOrder,
        };

        if (order.OrderId == 0)
        {
            order.NewOrder = true;
            context.Orders.Add(order);
        }
        else
        {
            Order dbEntry = context.Orders.FirstOrDefault(p => p.OrderId == order.OrderId);
            if (dbEntry != null)
            {
                dbEntry.Shipper = order.Shipper;
                dbEntry.Cargo = order.Cargo;
                dbEntry.Consignee = order.Consignee;
                dbEntry.Date = order.Date;
                dbEntry.NewOrder = true;
            }
        }
        context.SaveChanges();
        return true;
    }    
}

