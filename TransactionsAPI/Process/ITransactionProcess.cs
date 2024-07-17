using TransactionsAPI.DataModels;

namespace TransactionsAPI.Process
{
    public interface ITransactionProcess
    {
        Task<Transaction> CreateTransaction(Transaction transaction);
        Task<List<Transaction>> GetAllTransactions();
        Task<List<Transaction>> GetAllTransactions(int profileId);
        Task<Transaction> GetTransactionById(int transactionId);
        Task<bool> UpdateTransaction(Transaction transaction);
        Task<bool> DeleteTransaction(int transactionId);
    }
}
