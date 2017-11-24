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
                Console.WriteLine(GetBooksByPrice(db));
            }
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            Book[] books = context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .ToArray();

            var titlesAndPrices = new StringBuilder();

            for (int i = 0; i < books.Length; i++)
            {
                titlesAndPrices.Append($"{books[i].Title} - ${books[i].Price:f2}" + 
                    Environment.NewLine);
            }
            var result = String.Join("", titlesAndPrices);

            return result;
        }
    }
}
