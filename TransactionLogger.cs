public class TransactionLogger 
{
    public  void LogTransaction(int accountId, decimal amount, string transactionType)
  {
     Console.WriteLine($"Transaction logged: Account ID: {accountId}, Amount: {amount}, Type: {transactionType}");
  }

}