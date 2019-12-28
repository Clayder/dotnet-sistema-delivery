using System;

namespace dotnet_sistema_delivery.Models
{
    public class Order
    {

        public long Id { get; set; }

        public DateTime date { get; set; }

        public float priceTotal { get; set; }

        public float price { get; set; }
    }
}