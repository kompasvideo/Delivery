namespace Delivery.Hex.Drive;

public abstract class InputHandler<TRequest, TResult> where TRequest : InputRequest<TResult>
{
    protected abstract TResult? GetNullResult();

    /// <summary>
    /// Этот метод реализовать в наследниках. Здесь вызываются сервисы и диспетчеры.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    protected abstract Task<TResult> HandleRequest(TRequest request);


    public async Task<InputHandlerResponse<TResult>> HandleInput(TRequest request)
    {
        try
        {
            TResult result = await this.HandleRequest(request);

            InputHandlerResponseOk<TResult> ret = new InputHandlerResponseOk<TResult>(result);
            return ret;
        }
        catch (Exception ex)
        {
            return new InputHandlerResponseError<TResult>(GetNullResult(), ex);
        }
    }

}
