namespace Delivery.Hex.Domain.Command
{
    public class DeleteOrderCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}
