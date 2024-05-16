public class Program

{
    public static void Main(string[] args)
    {
        
        TransactionLogger logger = new TransactionLogger();

        AccountHandler account1 = new AccountHandler { AccountId = 1, HolderName = "John", Balance = 1000, AccountType = "Savings" };
        AccountHandler account2 = new AccountHandler { AccountId = 2, HolderName = "Alice", Balance = 2000, AccountType = "Current" };

        TransferableAccount transferableAccount = new TransferableAccount(logger);

        

        //TransferableAccount transferableAccount = new TransferableAccount { AccountId = 3, HolderName = "Bob", Balance = 1500, AccountType = "Savings" };
        transferableAccount.Transfer(account1.AccountId, account2.AccountId, 200);

        Console.WriteLine($"Account 1 Balance: {account1.Balance}");
        Console.WriteLine($"Account 2 Balance: {account2.Balance}");
        Console.WriteLine($"Transferable Account Balance: {transferableAccount.Balance}");
    }
}