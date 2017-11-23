namespace BookShop
{
    using BookShop.Data;
    using BookShop.Models;
    using BookShop.Initializer;
    using System.Linq;
    using System;

    public class StartUp
    {
        static void Main()
        {
            var command = Console.ReadLine();

            using (var db = new BookShopContext())
            {
                Console.WriteLine(GetBooksByAgeRestriction(db, command));
            }
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            int enumValue = -1;

            switch (command.ToLower())
            {
                case "minor":
                    enumValue = 0;
                    break;
                case "teen":
                    enumValue = 1;
                    break;
                case "adult":
                    enumValue = 2;
                    break;
                default:
                    break;
            }

            string[] titles = context.Books
                .Where(b => b.AgeRestriction == (AgeRestriction)enumValue)
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();
                
            var result = String.Join(Environment.NewLine, titles);

            return result;
        }
    }
}
