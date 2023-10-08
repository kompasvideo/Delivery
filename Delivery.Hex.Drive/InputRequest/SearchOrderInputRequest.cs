using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    public class SearchOrderInputRequest : SearchOrderData, InputRequest<IEnumerable<object>>
    {
    }
}

