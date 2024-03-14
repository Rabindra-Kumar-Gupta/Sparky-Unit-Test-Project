namespace Sparky
{
    public interface ILogBook
    {
        void Message(string message);
        bool LogToDb(string message);
        bool LogBalanceAfterWithdrawal(int balanceAfterWithdrawl);
        string MessageWithReturnStr(string message);
        bool LogWithOutputResult(string str, out string outputStr);
    }
    public class LogBook : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
        public bool LogBalanceAfterWithdrawal(int balanceAfterWithdrawl)
        {
            if (balanceAfterWithdrawl > 0)
            {
                Console.WriteLine("Withdrwal successfule!");
                return true;
            }
            Console.WriteLine("Withdrwal failure!");
            return false;
        }
        public bool LogToDb(string message)
        {
            Console.WriteLine(message);
            return true;
        }
        public string MessageWithReturnStr(string message)
        {
            Console.WriteLine(message);
            return message.ToLower();
        }
        public bool LogWithOutputResult(string str, out string outputStr)
        {
            outputStr = "Hello" + str;
            return true;
        }
    }
}
