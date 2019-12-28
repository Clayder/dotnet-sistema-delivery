
namespace dotnet_sistema_delivery.Models
{
    public class Product
    {
        public long Id { get; set; }

        public string name { get; set; }

        public Category category { get; set; }

        public Supplier supplier { get; set; }

        public float price { get; set; }

        public bool status { get; set; }

    }
}