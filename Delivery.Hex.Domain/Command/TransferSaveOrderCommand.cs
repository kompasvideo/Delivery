namespace Delivery.Hex.Domain.Command
{
    /// <summary>
    /// Данные для класса-команды для регистрации новой заявки 
    /// </summary>
    public class TransferSaveOrderCommand : ICommand<bool>
    {
        public int Id { get; set; }
        public string? CourierName { get; set; }
    }
}
