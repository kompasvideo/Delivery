using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    public class AddOrderCommandHandler : ICommandHandler<AddOrderCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(AddOrderCommand command)
        {
            Order order = new Order()
            {
                OrderId = command.OrderId,
                Date = command.Date,
                Shipper = command.Shipper,
                Consignee = command.Consignee,
                Cargo = command.Cargo,
                NewOrder = command.NewOrder,
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
        public AddOrderCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
    }
}
