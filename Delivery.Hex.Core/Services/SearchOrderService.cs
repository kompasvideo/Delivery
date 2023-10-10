using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
/// <summary>
/// класс-сервис вызывает непосредственно класс-запрос для поиска текста в полях заявки
/// </summary>
public class SearchOrderInputService : ISearchOrderInputService
{
    private readonly IQueryHandler<SearchOrderQuery, SearchOrderQueryModel?> _Query;
    public SearchOrderInputService(IQueryHandler<SearchOrderQuery, SearchOrderQueryModel?> query)
    {
        _Query = query;
    }
    public async Task<IEnumerable<object>> SearchOrderAsync(SearchOrderData data)
    {
        var model = await _Query.ExecuteAsync(new SearchOrderQuery() { Text = data.Text });
        return model.Orders;
    }
}

