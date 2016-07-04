using BankKata;
using TechTalk.SpecFlow;

namespace BankKataAcceptanceTests
{
    public class BankAccountKataSteps
    {
        private Account _account;
        private KataConsole _console;

        public BankAccountKataSteps(Account account)
        {
            this._account = account;
        }

        [Then(@"she would see")]
        public void PrintStatement_ContainingAllTransactions()
        {
            _account.Deposit(1000);
            _account.Withdraw(100);
            _account.Deposit(500);

            _account.PrintStatement();

            _console.Verify(x => x.PrintLine("DATE | AMOUNT | BALANCE"));
            _console.Verify(x => x.PrintLine("10/04/2014 | 500.00| 1400.00"));
            _console.Verify(x => x.PrintLine("02/04/2014 | -100.00 | 900.00"));
            _console.Verify(x => x.PrintLine("01/04/2014 | 1000.00 | 1000.00"));
        }
    }
}