using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    public class EditOrderCommandHandler : ICommandHandler<EditOrderCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(EditOrderCommand command)
        {
            Order orderEdit = context.Orders.FirstOrDefault(o => o.OrderId == command.OrderId);
            orderEdit.Date = command.Date;
            orderEdit.Shipper = command.Shipper;
            orderEdit.Consignee = command.Consignee;
            orderEdit.Cargo = command.Cargo;
            context.SaveChanges();
            return true;
        }
        public EditOrderCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
    }
}
