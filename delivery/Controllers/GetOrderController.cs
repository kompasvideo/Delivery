﻿using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class GetOrderController : ControllerBase
    {
        private readonly InputHandler<GetOrderInputRequest, object> _Handler;
        public GetOrderController(InputHandler<GetOrderInputRequest, object> handler)
        {
            _Handler = handler;
        }

        [HttpGet]
        [Route("/api/order/get/{id}")]
        public string Get(int id = 1)
        {
            var result = _Handler.HandleInput(new GetOrderInputRequest()
            {
                Id = id
            });
            string str = JsonConvert.SerializeObject(result.Result.Response);
            return str;
        }
    }
}
