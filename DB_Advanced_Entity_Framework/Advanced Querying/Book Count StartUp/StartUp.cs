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
            int lengthCheck = int.Parse(Console.ReadLine());

            using (var db = new BookShopContext())
            {
                var result = CountBooks(db, lengthCheck);
                Console.WriteLine(result);
            }
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Select(b => b.Title)
                .ToArray();

            var result = books.Count();
            return result;
        }
    }
}
