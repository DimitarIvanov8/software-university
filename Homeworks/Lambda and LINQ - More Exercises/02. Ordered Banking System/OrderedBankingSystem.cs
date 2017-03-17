using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ordered_Banking_System
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, decimal>> banksAndAccounts =
                new Dictionary<string, Dictionary<string, decimal>>();

            var bankName = "";
            var bankAccountName = "";
            var bankAccountBalance = 0m;

            while (line[0] != "end")
            {
                bankName = line[0];
                bankAccountName = line[1];
                bankAccountBalance = decimal.Parse(line[2]);

                if (!banksAndAccounts.ContainsKey(bankName))
                {
                    banksAndAccounts.Add(bankName, new Dictionary<string, decimal>());
                }
                if (!banksAndAccounts[bankName].ContainsKey(bankAccountName))
                {
                    banksAndAccounts[bankName].Add(bankAccountName, 0);
                }

                banksAndAccounts[bankName][bankAccountName] += bankAccountBalance;
                 
                line = Console.ReadLine()
                        .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var bank in banksAndAccounts.OrderByDescending(x => x.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine("{1} -> {2} ({0})", bank.Key, account.Key, account.Value);
                }
            }
        }
    }
}
