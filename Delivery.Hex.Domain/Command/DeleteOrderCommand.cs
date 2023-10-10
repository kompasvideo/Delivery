namespace Delivery.Hex.Domain.Command
{
    /// <summary>
    /// данные для класс-команды для удаления заявки
    /// </summary>
    public class DeleteOrderCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}
