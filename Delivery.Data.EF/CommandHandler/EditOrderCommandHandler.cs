using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    public class EditOrderCommandHandler : ICommandHandler<EditOrderCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(EditOrderCommand command)
        {
            context.Couriers.ToList();
            context.Clients.ToList();
            Order orderEdit = context.Orders.FirstOrDefault(o => o.OrderId == command.OrderId);
            orderEdit.Date = command.Date;
            orderEdit.Shipper = GetClientToName(command.Shipper);
            orderEdit.Consignee = GetClientToName(command.Consignee);
            orderEdit.Cargo = command.Cargo;
            context.SaveChanges();
            return true;
        }
        public EditOrderCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
        public Client GetClientToName(string name)
        {
            return context.Clients.FirstOrDefault(o => o.Name == name);
        }
    }
}
