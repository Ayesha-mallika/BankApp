public class AccountHandler: IAccount
{
   public int AccountId { get; set; }
    public string HolderName { get; set; }
    public decimal Balance { get; set; }
    public string AccountType { get; set; }
     TransactionLogger  _TransactionLogger =new TransactionLogger();
    


    public  void Deposit(int accountId, decimal amount)
    {
        Balance += amount;
        _TransactionLogger.LogTransaction( accountId,  amount,  "credit");

    }
         public virtual void Withdraw(int accountId, decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            _TransactionLogger.LogTransaction( accountId,  amount,  "debit");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
    
    public class SavingsAccount : AccountHandler
    {
      public void Transfer(decimal amount, AccountHandler recipientAccount)
      {
          
      }
    }
    public class CurrentAccount : AccountHandler
    {
       public void Transfer(decimal amount, AccountHandler recipientAccount)
      {
          
      }
    }
    public class PpfAccount : AccountHandler
    {

    }
}

