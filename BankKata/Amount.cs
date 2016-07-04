namespace BankKata
{
    public class Amount
    {
        private readonly int _amount;

        public Amount(int amount)
        {
            _amount = amount;
        }

        public string PrintAmount()
        {
            return _amount.ToString("F2");
        }
    }
}
