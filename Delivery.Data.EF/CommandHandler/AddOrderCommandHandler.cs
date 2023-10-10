using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    /// <summary>
    /// Класс-команда для регистрации новой заявки - выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class AddOrderCommandHandler : ICommandHandler<AddOrderCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(AddOrderCommand command)
        {
            context.Couriers.ToList();
            context.Clients.ToList();
            Order order = new Order()
            {
                OrderId = command.OrderId,
                Date = command.Date,
                Shipper = GetClientToName(command.Shipper),
                Consignee = GetClientToName(command.Consignee),
                Cargo = command.Cargo,
                StatusOrder = StatusOrder.NEW,
            };

            if (order.OrderId == 0)
            {
                order.StatusOrder = StatusOrder.NEW;
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
                    dbEntry.StatusOrder = StatusOrder.NEW;
                }
            }
            context.SaveChanges();
            return true;
        }
        public AddOrderCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
        public Client GetClientToName(string name)
        {
            return context.Clients.FirstOrDefault(o => o.Name == name);
        }
    }
}
