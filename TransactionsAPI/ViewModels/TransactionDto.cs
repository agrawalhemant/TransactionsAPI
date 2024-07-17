namespace TransactionsAPI.ViewModels
{
    public class TransactionDto
    {
        public int Profileid { get; set; }

        public string? TransactionName { get; set; }

        public int TransactionCategory { get; set; }

        public string Summary { get; set; }

        public int Amount { get; set; }

        public string PaymentGateway { get; set; }
    }
}
