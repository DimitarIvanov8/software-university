namespace BookShop
{
    using BookShop.Data;
    using BookShop.Models;
    using BookShop.Initializer;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        static void Main()
        {
            using (var db = new BookShopContext())
            {
                var result = CountCopiesByAuthor(db);
                Console.WriteLine(result);
            }
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                .Select(a => new
                {
                    Name = $"{a.FirstName} {a.LastName}",
                    Copies = a.Books.Select(b => b.Copies).Sum()
                })
                .OrderByDescending(a => a.Copies)
                .ToArray();
                
            var builder = new StringBuilder();
            foreach (var author in authors)
            {
                builder.Append($"{author.Name} - {author.Copies}" + Environment.NewLine);
            }

            return builder.ToString();
        }
    }
}
