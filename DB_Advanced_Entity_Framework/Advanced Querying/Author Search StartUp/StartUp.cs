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
                var result = GetAuthorNamesEndingIn(db, input);
                Console.WriteLine(result);
            }
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Books
                .Where(b => b.Author.FirstName.EndsWith(input))
                .OrderBy(a => a.Author.FirstName)
                .ThenBy(a => a.Author.LastName)
                .Select(a => $"{a.Author.FirstName} {a.Author.LastName}")
                .ToHashSet();

            var result = String.Join(Environment.NewLine, authors);
            return result;
        }
    }
}
