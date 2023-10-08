using Delivery.Hex.Domain.Model;

namespace Delivery.Hex.Domain.Query
{
    public class GetOrderQuery : IQuery<GetOrderQueryModel>
    {
        public int Id { get; set; }
    }
}
