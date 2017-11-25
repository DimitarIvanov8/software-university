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
                var result = GetBooksByCategory(db, input);
                Console.WriteLine(result);
            }
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.ToLower().Split(new[] { "\t", " ", Environment.NewLine}, 
                StringSplitOptions.RemoveEmptyEntries );

            string[] titles = context.Books
                .Where(b => b.BookCategories.Any(c => categories.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToArray();

            var result = String.Join(Environment.NewLine, titles);

            return result;
        }
    }
}
