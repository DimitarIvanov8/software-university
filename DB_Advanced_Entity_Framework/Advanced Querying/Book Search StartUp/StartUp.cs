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
            var input = Console.ReadLine();

            using (var db = new BookShopContext())
            {
                var result = GetBookTitlesContaining(db, input).Trim();
                Console.WriteLine(result);
            }
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(b =>  b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToArray();

            var result = String.Join(Environment.NewLine, books);
            return result;
        }
    }
}
