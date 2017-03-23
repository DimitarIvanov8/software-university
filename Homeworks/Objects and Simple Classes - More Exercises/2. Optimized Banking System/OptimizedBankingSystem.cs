using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Optimized_Banking_System
{
    class BankAccount
    {
        public string AccountName { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }

    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                string[] inputParams = line.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var bank = inputParams[0];
                var accountName = inputParams[1];
                var balance = inputParams[2];

                BankAccount newAccount = new BankAccount
                {
                    AccountName = accountName,
                    Bank = bank,
                    Balance = decimal.Parse(balance)
                };

                bankAccounts.Add(newAccount);
                line = Console.ReadLine();
            }

            var bankAccountsResult = bankAccounts
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length);
                                     
            foreach (var account in bankAccountsResult)
            {
                Console.WriteLine($"{account.AccountName} -> {account.Balance} ({account.Bank})");
            }
        }
    }
}
