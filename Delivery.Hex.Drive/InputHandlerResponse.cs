using Newtonsoft.Json;

namespace Delivery.Hex.Drive
{
    public class InputHandlerResponse<TResult>
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public InputHandlerPage? Page { get; set; }

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
