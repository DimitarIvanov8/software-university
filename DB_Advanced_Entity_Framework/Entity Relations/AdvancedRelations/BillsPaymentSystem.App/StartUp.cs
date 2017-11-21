using BillsPaymentSystem.Data;
using BillsPaymentSystem.Data.Models;
using System;
using System.Linq;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace BillsPaymentSystem.App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new BillsPaymentSystemContext())
            {
                db.Database.EnsureCreated();

                Seed(db);
            }

            var userId = int.Parse(Console.ReadLine());

            using (var db = new BillsPaymentSystemContext())
            {
                var user = db.Users
                    .Where(u => u.UserId == userId)
                    .Select(u => new
                    {
                        Name = $"{u.FirstName} {u.LastName}",
                        CreditCards = u.PaymentMethods
                            .Where(pm => pm.Type == PaymentMethodType.CreditCard)
                            .Select(pm => pm.CreditCard)
                            .ToList(),

                        BankAccounts = u.PaymentMethods
                            .Where(pm => pm.Type == PaymentMethodType.BankAccount)
                            .Select(pm => pm.BankAccount)
                            .ToList()
                    }).FirstOrDefault();

                Console.WriteLine($"User: {user.Name}");
                if (user.BankAccounts.Any())
                {
                    Console.WriteLine("Bank Accounts:");

                    foreach (var ba in user.BankAccounts)
                    {
                        Console.WriteLine($@"-- ID: {ba.BankAccountId}
--- Balance: {ba.Balance:f2}
--- Bank: {ba.BankName}
--- SWIFT: {ba.SWIFTCode}");
                    }
                }

                if (user.CreditCards.Any())
                {
                    Console.WriteLine("Credit Cards:");

                    foreach (var cc in user.CreditCards)
                    {
                        Console.WriteLine($@"-- ID: {cc.CreditCardId}
--- Limit: {cc.Limit:f2}
--- Money Owned: {cc.MoneyOwned:f2}
--- Limit Left: {cc.LimitLeft:f2}
--- Expiration Date: {cc.ExpirationDate.ToString("yyyy/MM", CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }

        private static void Seed(BillsPaymentSystemContext db)
        {
            using (db)
            {
                var user = new User()
                {
                    FirstName = "Hans",
                    LastName = "Yohanson",
                    Email = "hansRock@abv.bg",
                    Password = "1234"
                };

                var creditCard = new CreditCard()
                {
                    ExpirationDate = DateTime.ParseExact("20.05.2020", "dd.MM.yyyy", null),
                    Limit = 1000m,
                    MoneyOwned = 5m
                };

                var creditCard2 = new CreditCard()
                {
                    ExpirationDate = DateTime.ParseExact("20.05.2020", "dd.MM.yyyy", null),
                    Limit = 400m,
                    MoneyOwned = 200m
                };

                var bankAccount = new BankAccount()
                {
                    Balance = 1500m,
                    BankName = "Swiss Bank",
                    SWIFTCode = "SWSSBANK"
                };

                var paymentMethods = new PaymentMethod[]
                {
                    new PaymentMethod()
                    {
                        User = user,
                        CreditCard = creditCard,
                        Type = PaymentMethodType.CreditCard
                    },
                    new PaymentMethod()
                    {
                        User = user,
                        CreditCard = creditCard2,
                        Type = PaymentMethodType.CreditCard
                    },
                    new PaymentMethod()
                    {
                        User = user,
                        BankAccount = bankAccount,
                        Type = PaymentMethodType.BankAccount
                    },
                };

                db.Users.Add(user);
                db.CreditCards.Add(creditCard);
                db.CreditCards.Add(creditCard2);
                db.BankAccounts.Add(bankAccount);
                db.PaymentMethods.AddRange(paymentMethods);

                db.SaveChanges();
            }
        }
    }
}
