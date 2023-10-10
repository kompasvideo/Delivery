using DeliveryClient.Interfaces;
using DeliveryClient.Models;
using System.Text;
using Newtonsoft.Json;
using DeliveryClient.Mappers;

namespace DeliveryClient.Infrastructure
{
    /// <summary>
    /// Класс-сервис для передачи сообщений серверу
    /// </summary>
    public class OrderService : IOrderService
    {
        private const string host = "http://localhost:5001";
        private HttpClient httpClient { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Courier> Couriers { get; set; }
        private readonly IOrderMapper _OrderMapper;

        public OrderService(IOrderMapper orderMapper)
        {
            httpClient = new HttpClient();
            _OrderMapper = orderMapper;
        }

        /// <summary>
        /// получить все заявки
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetAll()
        {
            string url = host + "/api/order/get_all";
            string json = httpClient.GetStringAsync(url).Result;
            string str = JsonConvert.DeserializeObject<string>(json);
            Orders = JsonConvert.DeserializeObject<IEnumerable<Order>>(str);
            return Orders;
        }

        /// <summary>
        /// удалить заявку по id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteOrder(int id)
        {            
            string url = host + "/api/order/delete/" + id;
            _ = httpClient.DeleteAsync(url).Result;
        }

        /// <summary>
        /// сохранить изменённую заявку
        /// </summary>
        /// <param name="order">заявка</param>
        /// <returns></returns>
        public async Task EditOrder(Order order)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(host + "/api/order/edit");
            request.Method = HttpMethod.Post;
            string content = JsonConvert.SerializeObject(_OrderMapper.ToOrderDto(order));
            request.Content = new StringContent(content, Encoding.UTF8, mediaType: "application/json");
            await httpClient.SendAsync(request);
        }

        /// <summary>
        /// получить заявку по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Order GetOrderById(int id)
        {
            string url = host + "/api/order/get/" + id;
            string json = httpClient.GetStringAsync(url).Result;
            string str = JsonConvert.DeserializeObject<string>(json);
            Order order = JsonConvert.DeserializeObject<Order>(str);
            return order;
        }

        /// <summary>
        /// зарегистрировать новую заявку
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public async Task SaveOrder(Order order)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(host + "/api/order/add");
            request.Method = HttpMethod.Post;
            string content = JsonConvert.SerializeObject(_OrderMapper.ToOrderDto(order));
            request.Content = new StringContent(content, Encoding.UTF8, mediaType: "application/json");
            await httpClient.SendAsync(request);
        }

        /// <summary>
        /// поиск текста в заявках
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public IEnumerable<Order> SearchOrder(string text)
        {
            string url = host + "/api/order/search?text=" + text;
            string json = httpClient.GetStringAsync(url).Result;
            string str = JsonConvert.DeserializeObject<string>(json);
            Orders = JsonConvert.DeserializeObject<IEnumerable<Order>>(str);
            return Orders;
        }

        /// <summary>
        /// получить все клиенты (грузополучатели, грузоотправители)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Client> GetClients()
        {
            string url = host + "/api/order/get_all_clients";
            string json = httpClient.GetStringAsync(url).Result;
            Clients = JsonConvert.DeserializeObject<IEnumerable<Client>>(json);
            return Clients;
        }

        /// <summary>
        /// получить клиента по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Client GetClientToName(string name)
        {
            string url = host + "/api/order/get_all_clients";
            string json = httpClient.GetStringAsync(url).Result;
            Clients = JsonConvert.DeserializeObject<IEnumerable<Client>>(json);
            return Clients.FirstOrDefault(o => o.Name == name);
        }

        /// <summary>
        /// получить всех курьеров
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Courier> GetCouriers()
        {
            string url = host + "/api/order/get_all_couriers";
            string json = httpClient.GetStringAsync(url).Result;
            Couriers = JsonConvert.DeserializeObject<IEnumerable<Courier>>(json);
            return Couriers;
        }

        /// <summary>
        /// назначить курьера для заявки
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <param name="courier">имя курьера</param>
        /// <returns></returns>
        public async Task TransferOrderSave(int id, string courier)
        {
            string url = host + "/api/order/transfer_save/" + id +"?courier=" + courier;
            _ = httpClient.GetStringAsync(url).Result;
        }

        /// <summary>
        /// перевести статус заявки на "выполнено"
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <returns></returns>
        public async Task OrderDone(int id)
        {
            string url = host + "/api/order/order_done/" + id;
            _ = httpClient.GetStringAsync(url).Result;
        }

        /// <summary>
        /// перевести статус заявки на "отменено"
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <returns></returns>
        public async Task OrderCanceledSave(int id, string comments)
        {
            string url = host + "/api/order/order_canceled_save/" + id + "?comments=" + comments;
            _ = httpClient.GetStringAsync(url).Result;
        }
    }
}
