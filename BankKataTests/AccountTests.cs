using BankKata;
using NSubstitute;
using NUnit.Framework;

namespace BankKataTests
{
    [TestFixture]    
    public class AccountTests
    {
        [Test]
        public void Deposit_AmountIsGreaterThanZero_PrintsAmount()
        {
            KataConsole console = Substitute.For<KataConsole>();
            Account account = new Account(console);

            account.Deposit(new Amount(100));
            account.PrintStatement();

            console
                .Received(1)
                .PrintLine(Arg.Is<string>(m => m.Contains("100.0")));
        }
    }
}
