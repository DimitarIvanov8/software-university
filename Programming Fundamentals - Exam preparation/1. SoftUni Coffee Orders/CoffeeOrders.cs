using System;
using System.Collections.Generic;

namespace _1.SoftUni_Coffee_Orders
{
    class CoffeeOrders
    {
        static void Main(string[] args)
        {
            List<decimal> orders = new List<decimal>();
            var ordersNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < ordersNumber; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine().Split('/');

                var orderMonth = int.Parse(orderDate[1]);
                var orderYear = int.Parse(orderDate[2]);

                var daysInMonth = DateTime.DaysInMonth(orderYear, orderMonth);

                var capsuleCount = long.Parse(Console.ReadLine());

                var priceAfterDiscount = (decimal)(daysInMonth * capsuleCount) * pricePerCapsule;
                orders.Add(priceAfterDiscount);
            }

            var totalPrice = 0m;
            foreach (var coffee in orders)
            {
                totalPrice += coffee;
                Console.WriteLine($"The price for the coffee is: ${coffee:f2}");   
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
