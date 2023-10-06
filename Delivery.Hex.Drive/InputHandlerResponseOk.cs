namespace Delivery.Hex.Drive
{
    public class InputHandlerResponseOk<TResult> : InputHandlerResponse<TResult>
    {
        public InputHandlerResponseOk(TResult? result) : base(result) { }
    }
}
