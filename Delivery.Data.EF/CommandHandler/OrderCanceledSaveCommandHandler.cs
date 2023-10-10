using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    /// <summary>
    /// Класс-команда для регистрации новой заявки - выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class OrderCanceledSaveCommandHandler : ICommandHandler<OrderCanceledSaveCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(OrderCanceledSaveCommand command)
        {
            Order order = context.Orders.FirstOrDefault(o => o.OrderId == command.Id);
            order.Comments = command.Comments;
            order.StatusOrder = StatusOrder.CANCELLED;
            context.SaveChanges();
            return true;
        }
        public OrderCanceledSaveCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
    }
}
