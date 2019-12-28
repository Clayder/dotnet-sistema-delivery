using System;

namespace dotnet_sistema_delivery.Models
{
    public class Order
    {
        private int id { get; set; }

        private DateTime date { get; set; }

        private float priceTotal { get; set; }

        private float price { get; set; }
    }
}