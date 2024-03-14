namespace Sparky
{
    public class BankAccount
    {
        private readonly ILogBook _logBook;
        public int balance { get; set; }
        public BankAccount(ILogBook logBook) 
        {
            _logBook = logBook;
            balance = 0; 
        }
        public bool Deposit(int amount)
        {
            _logBook.Message("Diposit Invocked");
            balance+= amount;
            return true;
        }
        public bool Withraw(int amount)
        {
            if (amount <= balance)
            {
                _logBook.LogToDb("Withdrawl Amount: " + amount.ToString());
                balance -= amount;
                return _logBook.LogBalanceAfterWithdrawal(balance);
            }
            return _logBook.LogBalanceAfterWithdrawal(balance - amount);
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
