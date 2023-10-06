﻿using DeliveryClient.Interfaces;
using DeliveryClient.Models;
using System.Text;
using Newtonsoft.Json;

namespace DeliveryClient.Data
{
    public class OrderAPI : IOrder
    {
        private const string host = "http://localhost:5001";
        private HttpClient httpClient { get; set; }
        public IEnumerable<Order> Orders { get; set; }

        public OrderAPI()
        {
            httpClient = new HttpClient();
        }

        public IEnumerable<Order> GetAll()
        {
            string url = host + "/api/order/get_all";
            string json = httpClient.GetStringAsync(url).Result;
            Orders = JsonConvert.DeserializeObject<IEnumerable<Order>>(json);
            return Orders;
        }

        public void DeleteOrder(int id)
        {            
            string url = host + "/api/order/delete/" + id;
            _ = httpClient.GetStringAsync(url).Result;
        }

        public async Task EditOrder(Order order)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(host + "/api/order/edit");
            request.Method = HttpMethod.Post;
            request.Content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, mediaType: "application/json");
            await httpClient.SendAsync(request);
        }

        public Order GetOrderById(int id)
        {
            string url = host + "/api/order/get/" + id;
            string json = httpClient.GetStringAsync(url).Result;
            Order order = JsonConvert.DeserializeObject<Order>(json);
            return order;
        }

        public async Task SaveOrder(Order order)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(host + "/api/order/add");
            request.Method = HttpMethod.Post;
            request.Content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, mediaType: "application/json");
            await httpClient.SendAsync(request);
        }

        public IEnumerable<Order> SearchOrder(string text)
        {
            string url = host + "/api/order/search?text=" + text;
            string json = httpClient.GetStringAsync(url).Result;
            Orders = JsonConvert.DeserializeObject<IEnumerable<Order>>(json);
            return Orders;
        }
    }
}