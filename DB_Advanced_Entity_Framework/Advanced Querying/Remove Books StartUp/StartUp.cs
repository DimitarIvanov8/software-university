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
                Console.WriteLine($"{RemoveBooks(db)} books were deleted");
            }
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 4200)
                .ToArray();

            int result = books.Count();
            
			context.RemoveRange(books);
			
            context.SaveChanges();

            return result;
        }
    }
}
