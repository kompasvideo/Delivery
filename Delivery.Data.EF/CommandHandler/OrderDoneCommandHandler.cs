using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    /// <summary>
    /// Класс-команда для регистрации новой заявки - выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class OrderDoneCommandHandler : ICommandHandler<OrderDoneCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(OrderDoneCommand command)
        {
            Order order = context.Orders.FirstOrDefault(o => o.OrderId == command.Id);
            order.StatusOrder = StatusOrder.DONE;
            context.SaveChanges();
            return true;
        }
        public OrderDoneCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
    }
}
