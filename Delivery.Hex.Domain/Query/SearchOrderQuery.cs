using Delivery.Hex.Domain.Model;

namespace Delivery.Hex.Domain.Query
{
    public class SearchOrderQuery : IQuery<SearchOrderQueryModel>
    {
        public string Text { get; set; }
    }
}
