using DeliveryClient.Interfaces;
using DeliveryClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeliveryClient.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrder _orderRepository;

        public OrderController(IOrder order)
        {
            _orderRepository = order;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View(_orderRepository.GetClients());
        }

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

        public IActionResult ViewAll()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }

        public IActionResult Search()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SearchOrder(string text)
        {
            IEnumerable<Order> orders = _orderRepository.SearchOrder(text);
            ViewData["text"] = text;
            return View(orders);
        }

        public IActionResult Transfer()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }

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

        [HttpPost]
        public RedirectToActionResult TransferOrderSave(int id, string courier)
        {
            _orderRepository.TransferOrderSave(id, courier);
            Thread.Sleep(1000);
            return RedirectToAction("Transfer");
        }

        public IActionResult EditOrder()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }
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

        public IActionResult DeleteOrder()
        {
            _orderRepository.GetAll();
            return View(_orderRepository.Orders);
        }

        [HttpPost]
        public RedirectToActionResult DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
            Thread.Sleep(1000);
            return RedirectToAction("DeleteOrder");
        }

        [HttpPost]
        public RedirectToActionResult OrderDone(int id)
        {
            _orderRepository.OrderDone(id);
            return RedirectToAction("EditOrder");
        }


        [HttpPost]
        public IActionResult OrderCanceled(int id)
        {
            Order order = _orderRepository.GetOrderById(id);
            return View(order);
        }

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