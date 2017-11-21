using System;

namespace BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public decimal Limit { get; set; }
        public decimal MoneyOwned { get; set; }
        public DateTime ExpirationDate { get; set; }

        public decimal LimitLeft => this.Limit - this.MoneyOwned;

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
