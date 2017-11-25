namespace BookShop
{
    using BookShop.Data;
    using BookShop.Models;
    using BookShop.Initializer;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            using (var db = new BookShopContext())
            {
                var result = GetTotalProfitByCategory(db);
                Console.WriteLine(result);
            }
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categoriesProfit = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    BookProfit = c.CategoryBooks.Select(cb => cb.Book.Copies * cb.Book.Price).Sum()
                })
                .OrderByDescending(c => c.BookProfit)
                .ThenBy(c => c.CategoryName)
                .ToArray();

            var builder = new StringBuilder();
            foreach (var category in categoriesProfit)
            {
                builder.Append($"{category.CategoryName} ${(category.BookProfit):f2}" + Environment.NewLine);
            }

            return builder.ToString().Trim();
        }
    }
}
