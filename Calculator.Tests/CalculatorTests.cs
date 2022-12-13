namespace Calculator.Tests
{
  public class CalculatorTests
  {

    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    [TestCase(1, 1)]
    [TestCase(1, 2)]
    [TestCase(1, 3)]
    [TestCase(3, 1)]
    public void Add_TwoNumbers_ReturnTotal(int first, int second)
    {
      Calculator1 calculator = new Calculator1();
      int actual = calculator.Add(first, second);
      int expected = first + second;
      Assert.AreEqual(actual, expected);
    }

    [Test]
    [TestCase(1, 2)]
    [TestCase(2, 2)]
    [TestCase(3, 2)]
    [TestCase(4, 10)]
    public void Multiply_TwoNumbers_ReturnProduct(int first, int second)
    {
      Calculator1 calculator = new Calculator1();
      int actual = calculator.Multiply(first, second);
      int expected = first * second;
      Assert.AreEqual(actual, expected);
    }
  }
}