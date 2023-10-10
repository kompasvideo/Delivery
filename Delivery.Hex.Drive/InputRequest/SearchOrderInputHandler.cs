using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// Класс для вызова класса-сервиса для поиска текста во всех полях заявки
    /// </summary>
    public class SearchOrderInputHandler : InputHandler<SearchOrderInputRequest, IEnumerable<object>>
    {
        private readonly ISearchOrderInputService _Service;
        public SearchOrderInputHandler(ISearchOrderInputService service)
        {
            _Service = service;
        }

        protected override IEnumerable<object> GetNullResult() => Enumerable.Empty<object>();

        protected override async Task<IEnumerable<object>> HandleRequest(SearchOrderInputRequest request)
        {
            return await _Service.SearchOrderAsync(request);
        }
    }
}

