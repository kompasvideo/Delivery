using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
/// <summary>
/// класс-сервис вызывает непосредственно класс-запрос для получения заявки по id
/// </summary>
public class GetOrderInputService : IGetOrderInputService
{
    private readonly IQueryHandler<GetOrderQuery, GetOrderQueryModel?> _Query;
    public GetOrderInputService(IQueryHandler<GetOrderQuery, GetOrderQueryModel?> query)
    {
        _Query = query;
    }

    public async Task<object> GetOrderAsync(GetOrderData data)
    {
        var model = await _Query.ExecuteAsync(new GetOrderQuery() { Id = data.Id });
        return model.Order;
    }
}

