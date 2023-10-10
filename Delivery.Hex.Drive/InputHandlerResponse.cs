using Newtonsoft.Json;

namespace Delivery.Hex.Drive
{
    public class InputHandlerResponse<TResult>
    {
        public virtual bool HasError { get; } = false;
        public TResult? Response { get; private set; }

        public InputHandlerResponse(TResult? result)
        {
            Response = result;
        }
    }

    public class InputHandlerResponse<TContainer, TResult>
    {
    }
}
