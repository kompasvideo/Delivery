using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class EditOrderInputService : IEditOrderInputService
{
    private readonly DeliveryOrderDb context;
    public EditOrderInputService(DeliveryOrderDb ctx)
    {
        context = ctx;
    }
    public async Task<bool> EditOrderAsync(EditOrderData data)
    {
        Order orderEdit = context.Orders.FirstOrDefault(o => o.OrderId == data.OrderId);
        orderEdit.Date = data.Date;
        orderEdit.Shipper = data.Shipper;
        orderEdit.Consignee = data.Consignee;
        orderEdit.Cargo = data.Cargo;
        context.SaveChanges();
        return true;
    }    
}

