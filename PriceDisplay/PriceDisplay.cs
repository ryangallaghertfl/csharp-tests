namespace PriceDisplay
{
    public class PriceDisplay
    {
        public string GetPriceLabel(string itemName, double price)
        {
            return $"The price for item: {itemName} is {price}";
        }
    }
}