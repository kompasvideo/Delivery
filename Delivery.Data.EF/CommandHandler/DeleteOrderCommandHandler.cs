using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Data.EF.CommandHandler
{
    /// <summary>
    /// Класс-команда для удаления заявки - выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class DeleteOrderCommandHandler : ICommandHandler<DeleteOrderCommand, bool>
    {
        private readonly DeliveryOrderDb context;

        public async Task<bool> ExecuteAsync(DeleteOrderCommand command)
        {
            int id = command.Id;
            Order order = context.Orders.FirstOrDefault(p => p.OrderId == id);
            if (order != null)
            {
                context.Orders.Remove(order);
                context.SaveChanges();
            }
            return true;
        }
        public DeleteOrderCommandHandler(DeliveryOrderDb ctx)
        {
            context = ctx;
        }
    }
}
