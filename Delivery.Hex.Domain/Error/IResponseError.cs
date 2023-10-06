namespace Delivery.Hex.Domain.Error
{
    public interface IResponseError
    {
        string ResponseErrorMessage { get; }

        ResponseErrorCode ResponseErrorCode { get; }
    }
}
