public interface IAccount
{
    void Deposit(int accountId, decimal amount);
    void Withdraw(int accountId, decimal amount);
}
