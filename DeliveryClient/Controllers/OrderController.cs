using DeliveryClient.Interfaces;
using DeliveryClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeliveryClient.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderRepository;

        public OrderController(IOrderService order)
        {
            _orderRepository = order;
        }

        /// <summary>
        /// вывод страницы Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// вывод страницы Add - зарегистрировать заявку
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            return View(_orderRepository.GetClients());
        }

        /// <summary>
        /// обработать зарегистрированную заявку и перейти на страницу Index
        /// </summary>
        /// <param name="date">дата заявки</param>
        /// <param name="shipper">грузоотправитель</param>
        /// <param name="consignee">грузополучатель</param>
        /// <param name="cargo">груз</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult AddOrder(string date, string shipper, string consignee, string cargo)
        {
            Order order = new Order();
            order.Date = date;
            order.Shipper = _orderRepository.GetClientToName(shipper);
            order.Consignee = _orderRepository.GetClientToName(consignee);
            order.Cargo = cargo;
            _orderRepository.SaveOrder(order);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// показть все заявки на странице
        /// </summary>
        /// <returns></returns>
        public IActionResult ViewAll()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }

        /// <summary>
        /// вывести окно поиска заявок
        /// </summary>
        /// <returns></returns>
        public IActionResult Search()
        {
            return View();
        }

        /// <summary>
        /// вывести окно результата поиска заявок
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SearchOrder(string text)
        {
            IEnumerable<Order> orders = _orderRepository.SearchOrder(text);
            ViewData["text"] = text;
            return View(orders);
        }

        /// <summary>
        /// вывести окно для передачи завки курьеру 
        /// </summary>
        /// <returns></returns>
        public IActionResult Transfer()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }

        /// <summary>
        /// вывести окно выбора курьера для заявки
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult TransferOrder(int id)
        {
            ViewTransfer viewTransfer = new ViewTransfer()
            {
                Couriers = _orderRepository.GetCouriers(),
                Order = _orderRepository.GetOrderById(id),
            };
            return View(viewTransfer);
        }

        /// <summary>
        /// обработать назначения курьера на заявку и перейти на страницу поиска
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <param name="courier">Имя курьера</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult TransferOrderSave(int id, string courier)
        {
            _orderRepository.TransferOrderSave(id, courier);
            Thread.Sleep(1000);
            return RedirectToAction("Transfer");
        }

        /// <summary>
        /// страница редактирования заявок
        /// </summary>
        /// <returns></returns>
        public IActionResult EditOrder()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }

        /// <summary>
        /// страница редактирования конкретной заявки по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ViewEditOrder(int id)
        {
            ViewEdit viewEdit = new ViewEdit()
            {
                Order = _orderRepository.GetOrderById(id),
                Clients = _orderRepository.GetClients()
            };
            return View(viewEdit);
        }

        /// <summary>
        /// сохранения редактированной заявки и переход на страницу редактирования заявок
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <param name="date">дата заявки</param>
        /// <param name="shipper">грузоотправитель</param>
        /// <param name="consignee">грузополучатель</param>
        /// <param name="cargo">груз</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult EditOrderSave(int id, string date, string shipper, string consignee, string cargo)
        {
            Order order = new Order
            {
                OrderId = id,
                Date = date,
                Shipper = _orderRepository.GetClientToName(shipper),
                Consignee = _orderRepository.GetClientToName(consignee),
                Cargo = cargo
            };
            _orderRepository.EditOrder(order);
            Thread.Sleep(1000);
            return RedirectToAction("EditOrder");
        }

        /// <summary>
        /// показ заявок для удаления
        /// </summary>
        /// <returns></returns>
        public IActionResult DeleteOrder()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }

        /// <summary>
        /// удаление заявки по id
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
            Thread.Sleep(1000);
            return RedirectToAction("DeleteOrder");
        }

        /// <summary>
        /// изменение статуса заявки на "выполнено"
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult OrderDone(int id)
        {
            _orderRepository.OrderDone(id);
            return RedirectToAction("EditOrder");
        }

        /// <summary>
        /// страница ввода причины отмены заявки
        /// </summary>
        /// <param name="id">id заявки</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult OrderCanceled(int id)
        {
            Order order = _orderRepository.GetOrderById(id);
            return View(order);
        }

        /// <summary>
        /// изменение статуса заявки на "отменено"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="comments"></param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult OrderCanceledSave(int id, string comments)
        {
            _orderRepository.OrderCanceledSave(id, comments);
            Thread.Sleep(1000);
            return RedirectToAction("EditOrder");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}