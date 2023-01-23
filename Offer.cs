namespace ProductServiceTest
{
    public class Offer
    {
        public string OfferName { get; set; }

        public List<Product> Products { get; set; }

        Offer(string offerName, List<Product> products)
        {
            OfferName = offerName;
            Products = products;
        }
    }
}
