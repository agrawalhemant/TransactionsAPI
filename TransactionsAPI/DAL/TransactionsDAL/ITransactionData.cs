using TransactionsAPI.ViewModels;

namespace TransactionsAPI.DAL.TransactionDAL
{
    public interface ITransactionData
    {
        Task<List<TransactionDto>> GetAllTransactions();
        Task<Transaction> GetTransactionById(int transactionId);
        Task CreateTransaction(TransactionDto transaction);
        Task<bool> DeleteTransaction(int transactionId);
        Task<List<int>> DeleteAllTransactions(List<int> transactionIds);
        Task UpdateTransaction(TransactionDto transaction);
        Task PatchTransaction(TransactionDto transaction);
    }
}
