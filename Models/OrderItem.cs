using System;

namespace dotnet_sistema_delivery.Models
{
    public class OrderItem
    {
        private int id { get; set; }

        private Product product { get; set; }

        private float price { get; set; }

        private DateTime date { get; set; }


    }
}