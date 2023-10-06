using Delivery.Hex.Domain.Data;
namespace Delivery.Hex.Drive.InputRequest
{
    public class SearchOrderInputRequest : SearchOrderData, InputRequest<IEnumerable<object>>
    {
    }
}

