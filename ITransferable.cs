public interface ITransferable 
{
    public void Transfer(int sourceAccountId, int destinationAccountId, decimal amount);
}