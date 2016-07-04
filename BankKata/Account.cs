using System;
using System.Collections.Generic;

namespace BankKata
{
    public class Account
    {
        private readonly KataConsole _console;
        private readonly IList<Amount> _depositAmountRecord;

        public Account(KataConsole console)
        {
            _depositAmountRecord = new List<Amount>();
            _console = console;
        }

        public void Deposit(Amount amount)
        {
            _depositAmountRecord.Add(amount);
        }

        public void Withdraw(int amount)
        {
            throw new NotImplementedException();
        }

        public void PrintStatement()
        {
            foreach (Amount amount in _depositAmountRecord)
            {
                // (this will fail)
                _console.PrintLine(amount.ToString());
            }
        }
    }
}