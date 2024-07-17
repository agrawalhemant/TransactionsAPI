using TransactionsAPI.DataModels;

namespace TransactionsAPI.DAL.TransactionsDAL
{
    public interface ITransactionData
    {
        Task<List<Transaction>> GetAllTransactions();
        Task<List<Transaction>> GetTransactionsByIds(List<int> transactionIds);
        Task<List<Transaction>> GetAllTransactions(Guid profileId);
        Task<Transaction> GetTransactionById(int transactionId);
        Task CreateTransaction(Transaction transaction);
        Task<bool> DeleteTransaction(int transactionId);
        Task<bool> DeleteAllTransactions(List<int> transactionIds);
        Task<bool> UpdateTransaction(Transaction transaction);
        Task PatchTransaction(Transaction transaction);
    }
}
