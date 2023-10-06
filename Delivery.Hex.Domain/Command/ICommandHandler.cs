namespace Delivery.Hex.Domain.Command
{
    public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand<TResult>
    {
        Task<TResult> ExecuteAsync(TCommand command);
    }
}

