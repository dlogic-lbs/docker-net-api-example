namespace DockerAPI
{
    public class Prices
    {
        public Prices(uint SetProductId, List<Money> SetProductPrices)
        {
            ProductId = SetProductId;
            ProductPrices = SetProductPrices;
        }

        public uint ProductId { get; set; }

        public List<Money> ProductPrices { get; set; }
    }
}
