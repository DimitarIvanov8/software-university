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
                var result = GetMostRecentBooks(db);
                Console.WriteLine(result);
            }
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categoriesBooks = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Books = c.CategoryBooks.Select(cb => cb.Book)
                        .OrderByDescending(b => b.ReleaseDate)
                        .Take(3)
                }).ToArray();

            var builder = new StringBuilder();
            foreach (var category in categoriesBooks.OrderBy(b => b.Name))
            {
                builder.AppendLine($"--{category.Name}");

                foreach (var book in category.Books)
                {
                    builder.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }

            return builder.ToString().Trim();
        }
    }
}
