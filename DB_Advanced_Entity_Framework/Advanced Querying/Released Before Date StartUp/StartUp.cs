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
            var date = Console.ReadLine();

            using (var db = new BookShopContext())
            {
                var result = GetBooksReleasedBefore(db, date);
                Console.WriteLine(result);
            }
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string inputDate)
        {
            DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", null);

            var books = context.Books
                .Where(b => b.ReleaseDate < date)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}")
                .ToArray();

            var result = String.Join(Environment.NewLine, books);
            return result;
        }
    }
}
