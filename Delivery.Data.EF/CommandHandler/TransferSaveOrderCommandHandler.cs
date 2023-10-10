using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    /// <summary>
    /// Класс-команда для регистрации новой заявки - выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class TransferSaveOrderCommandHandler : ICommandHandler<TransferSaveOrderCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(TransferSaveOrderCommand command)
        {
            context.Couriers.ToList();
            context.Clients.ToList();
            Order orderTransfer = context.Orders.FirstOrDefault(o => o.OrderId == command.Id);
            Courier courier = context.Couriers.FirstOrDefault(c => c.Name == command.CourierName);
            orderTransfer.Courier = courier;
            orderTransfer.StatusOrder = StatusOrder.TRANSMITTED;
            context.SaveChanges();
            return true;
        }
        public TransferSaveOrderCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
    }
}
