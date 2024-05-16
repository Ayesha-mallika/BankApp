public class TransferableAccount :ITransferable
{
    private readonly IAccount _IAccount;
    private readonly TransactionLogger _TransactionLogger;

    public TransferableAccount(IAccount IAccount,TransactionLogger TransactionLogger)
    {
        _IAccount = IAccount;
        _TransactionLogger=TransactionLogger;
      
    }

    public void Transfer(int sourceAccountId, int destinationAccountId, decimal amount)
    {
        _IAccount.Withdraw(sourceAccountId, amount);
        _TransactionLogger.LogTransaction(sourceAccountId, amount, "debit");
        _IAccount.Deposit(destinationAccountId, amount);
        _TransactionLogger.LogTransaction(sourceAccountId, amount, "credit");
        

    }
}