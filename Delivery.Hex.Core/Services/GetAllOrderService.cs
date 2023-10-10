using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
/// <summary>
/// класс-сервис вызывает непосредственно класс-запрос для получения всех заявок
/// </summary>
public class GetAllOrderInputService : IGetAllOrderInputService
{
    private readonly IQueryHandler<GetAllQuery, GetAllQueryModel?> _Query;
    public GetAllOrderInputService(IQueryHandler<GetAllQuery, GetAllQueryModel?> query)
    {
        _Query = query;
    }
    public async Task<IEnumerable<object>> GetAllOrderAsync(GetAllOrderData data)
    {
        var model = await _Query.ExecuteAsync(new GetAllQuery());
        return model.Orders;
    }
}

