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
            var yearInput = int.Parse(Console.ReadLine());

            using (var db = new BookShopContext())
            {
                var result = GetBooksNotRealeasedIn(db, yearInput);
                Console.WriteLine(result);
            }
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            string[] books = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(e => e.Title)
                .ToArray();

            var titles = new StringBuilder();

            for (int i = 0; i < books.Length; i++)
            {
                titles.Append($"{books[i]}" + 
                    Environment.NewLine);
            }
            var result = String.Join("", titles);

            return result;
        }
    }
}
