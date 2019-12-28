

namespace dotnet_sistema_delivery.Models
{
    public class Stock
    {
        public long Id { get; set; }

        public Product product { get; set; }

        public int qty { get; set; }
    }
}