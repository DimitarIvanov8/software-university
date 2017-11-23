namespace BookShop
{
    using BookShop.Data;
    using BookShop.Models;
    using BookShop.Initializer;
    using System;

    public class StartUp
    {
        static void Main()
        {
            var command = Console.ReadLine();

            using (var db = new BookShopContext())
            {
                DbInitializer.ResetDatabase(db);
            }
        }
    }
}
