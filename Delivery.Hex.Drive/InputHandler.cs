namespace Delivery.Hex.Drive;

public abstract class InputHandler<TRequest, TResult> where TRequest : InputRequest<TResult>
{
    protected abstract TResult? GetNullResult();

    protected InputHandlerPage? _Page { get; set; }

    public InputHandler()
    {
    }
    /// <summary>
    /// Этот метод реализовать в наследниках. Здесь вызываются сервисы и диспетчеры.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    protected abstract Task<TResult> HandleRequest(TRequest request);


    public async Task<InputHandlerResponse<TResult>> HandleInput(TRequest request)
    {
        Task? log = null;

        try
        {
            TResult result = await this.HandleRequest(request);

            InputHandlerResponseOk<TResult> ret = new InputHandlerResponseOk<TResult>(result);

            if (_Page != null)
            {
                ret.Page = _Page;
            }

            if (log != null)
            {
                await log;
            }

            return ret;
        }
        catch (Exception ex)
        {
            return new InputHandlerResponseError<TResult>(GetNullResult(), ex);
        }
    }

}
