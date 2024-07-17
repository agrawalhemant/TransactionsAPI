
using TransactionsAPI.DataModels;

namespace TransactionsAPI.Process
{
    public class TransactionProcess : ITransactionProcess
    {
        public Task<Transaction> CreateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTransaction(int transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Transaction>> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public Task<List<Transaction>> GetAllTransactions(int profileId)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetTransactionById(int transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
