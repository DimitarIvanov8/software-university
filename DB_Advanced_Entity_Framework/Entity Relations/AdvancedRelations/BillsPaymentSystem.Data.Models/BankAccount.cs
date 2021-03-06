﻿using System.Collections.Generic;

namespace BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public decimal Balance { get; set; }
        public string BankName { get; set; }
        public string SWIFTCode { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
