namespace dotnet_sistema_delivery.Models
{
    public class Product
    {
        private int id { get; set; }

        private string name { get; set; }

        private Category category { get; set; }

        private Supplier supplier { get; set; }

        private float price { get; set; }

        private bool status { get; set; }

    }
}