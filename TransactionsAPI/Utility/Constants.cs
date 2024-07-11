using System.ComponentModel.DataAnnotations;

namespace TransactionsAPI.Utility
{
    public class Constants
    {
        public enum PaymentGatewayEnum
        {
            [Display(Name = "Cash")]
            cash = 1,

            [Display(Name = "Paytm")]
            paytm,

            [Display(Name = "PhonePe")]
            phonepe,

            [Display(Name = "Amazon Pay")]
            amazon_pay,

            [Display(Name = "CRED")]
            cred,

            [Display(Name = "GPay")]
            gpay,

            [Display(Name = "ICICI Debit Card")]
            icici_debit_card,

            [Display(Name = "ICICI Credit Card")]
            icici_credit_card,

            [Display(Name = "BOB Debit Card")]
            bob_debit_card,

            [Display(Name = "BOB Credit Card")]
            bob_credit_card,

            [Display(Name = "HDFC Debit Card")]
            hdfc_debit_card,

            [Display(Name = "HDFC Credit Card")]
            hdfc_credit_card
        }
    }
}
