using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;

/// <summary>
/// класс-сервис вызывает непосредственно класс-запрос для получения всех клиентов (грузополучателей, грузоотправителей)
/// </summary>
public class GetAllCouriersInputService : IGetAllCouriersInputService
{
    private readonly IQueryHandler<GetAllCouriersQuery, GetAllCouriersQueryModel?> _Query;
    public GetAllCouriersInputService(IQueryHandler<GetAllCouriersQuery, GetAllCouriersQueryModel?> query)
    {
        _Query = query;
    }
    public async Task<IEnumerable<object>> GetAllCouriersAsync(GetAllCouriersData data)
    {
        var model = await _Query.ExecuteAsync(new GetAllCouriersQuery());
        return model.Couriers;
    }
}

