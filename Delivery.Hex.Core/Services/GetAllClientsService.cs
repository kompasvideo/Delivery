using Delivery.Hex.Domain.Entity;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;

/// <summary>
/// класс-сервис вызывает непосредственно класс-запрос для получения всех клиентов (грузополучателей, грузоотправителей)
/// </summary>
public class GetAllClientsInputService : IGetAllClientsInputService
{
    private readonly IQueryHandler<GetAllClientsQuery, GetAllClientsQueryModel?> _Query;
    public GetAllClientsInputService(IQueryHandler<GetAllClientsQuery, GetAllClientsQueryModel?> query)
    {
        _Query = query;
    }
    public async Task<IEnumerable<object>> GetAllClientsAsync(GetAllClientsData data)
    {
        var model = await _Query.ExecuteAsync(new GetAllClientsQuery());
        return model.Clients;
    }
}

