namespace dotnet_sistema_delivery.Models
{
    public class Promotion
    {
        private int id { get; set; }

        private string name { get; set; }

        private Product product { get; set; }

        private float discount { get; set; }

        private bool status;
    }
}