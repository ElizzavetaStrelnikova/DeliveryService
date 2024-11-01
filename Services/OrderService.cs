﻿using DeliveryServiceSystem.Models;
using System.Text.Json;

namespace DeliveryServiceSystem.Services
{
    public class OrderService
    {
        public List<Order> LoadOrders(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Order>>(json);
        }
    }
}
