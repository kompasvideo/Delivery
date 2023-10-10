namespace Delivery.Hex.Domain.Command
{
    /// <summary>
    /// Данные для класса-команды 
    /// </summary>
    public class OrderCanceledSaveCommand : ICommand<bool>
    {
        public int Id { get; set; }
        public string Comments { get; set; }
    }
}
