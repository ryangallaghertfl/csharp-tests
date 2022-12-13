namespace PriceDisplay.Tests
{
  public class PriceDisplayTests
  {

    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    [TestCase("coffee", 4.99)]
    [TestCase("tea", 2.30)]
    [TestCase("milk", 1.39)]
    [TestCase("hot chocolate", 3.39)]
    public void GetPriceLabel_returns_string(string itemName, double price)
    {
      PriceDisplay pricedisplay = new PriceDisplay();
      string actual = pricedisplay.GetPriceLabel(itemName, price);
      string expected = $"The price for item: {itemName} is {price}";
      Assert.AreEqual(actual, expected);
    }
  }
}