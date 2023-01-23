namespace ProductServiceTest
{
    public class OfferService
    {
        private List<Product> Inventory { get; set; }

        private List<Product> GetAllProducts()
        {
            Product product = new Product
                ("P1", 1000, "P1 Desc");

            Inventory = new List<Product>
            {
                new Product ("P1",1000,"P1 Desc" ),
                new Product ("P2",200,"P2 Desc" ),
                new Product ("P3",400,"P3 Desc" ),
                new Product ("P4",700,"P4 Desc" ),
                new Product ("P5",600,"P5 Desc" ),
                new Product ("P6",800,"P6 Desc" ),
            };

            return Inventory;
        }
    }
}
