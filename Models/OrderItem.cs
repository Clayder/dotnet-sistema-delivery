using System;

namespace dotnet_sistema_delivery.Models
{
    public class OrderItem
    {

        public long Id { get; set; }

        public Product product { get; set; }

        public float price { get; set; }

        public DateTime date { get; set; }


    }
}