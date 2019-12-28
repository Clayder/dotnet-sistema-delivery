

namespace dotnet_sistema_delivery.Models
{
    public class Promotion
    {

        public long Id { get; set; }

        public string name { get; set; }

        public Product product { get; set; }

        public float discount { get; set; }

        public bool status;
    }
}