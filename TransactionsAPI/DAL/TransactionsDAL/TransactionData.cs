using TransactionsAPI.DataModels;

namespace TransactionsAPI.DAL.TransactionsDAL
{
    public class TransactionData : ITransactionData
    {
        private TransactionDbContext _context;
        public TransactionData(TransactionDbContext context)
        {
            _context = context;
        }

        public async Task CreateTransaction(Transaction transaction)
        {
            var res = await _context.Transaction.AddAsync(transaction);
            var res1 = await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAllTransactions(List<int> transactionIds)
        {
            List<Transaction> transactions = await GetTransactionsByIds(transactionIds);
            _context.Transaction.RemoveRange(transactions);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTransaction(int transactionId)
        {
            var res = await _context.Transaction.Where(x=> x.tid==transactionId).ExecuteDeleteAsync();
            return true;
        }

        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await _context.Transaction.ToListAsync();
        }

        public async Task<List<Transaction>> GetAllTransactions(Guid profileId)
        {
            List<Transaction>? transactions = null;
            transactions = await _context.Transaction.Where(x => x.profileid == profileId).ToListAsync();
            return transactions;
        }
        public async Task<List<Transaction>> GetTransactionsByIds(List<int> transactionIds)
        {
            return await _context.Transaction.Where(x => transactionIds.Contains(x.tid)).ToListAsync();
        }
        public async Task<Transaction> GetTransactionById(int transactionId)
        {
            return await _context.Transaction.Where(x => x.tid == transactionId).FirstOrDefaultAsync();
        }

        public Task PatchTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateTransaction(Transaction transaction)
        {
            Transaction tsc = await GetTransactionById(transaction.tid);
            tsc.name = transaction.name;
            tsc.category = transaction.category;
            tsc.summary = transaction.summary;
            tsc.amount = transaction.amount;
            tsc.payment_gateway = transaction.payment_gateway;
            tsc.updated_at = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
