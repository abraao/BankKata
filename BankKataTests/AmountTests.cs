using BankKata;
using NUnit.Framework;

namespace BankKataTests
{
    [TestFixture]
    public class AmountTests
    {
        [Test]
        public void Constructor_AmountIsProvided_ClassIsCreated()
        {
            var amount = new Amount(100);

            Assert.IsNotNull(amount);
        }

        [Test]
        public void PrintAmount_AmountIsProvided_AmountIsPrinted()
        {
            var amount = new Amount(100);

            Assert.AreEqual("100.00", amount.PrintAmount());
        }
    }
}
