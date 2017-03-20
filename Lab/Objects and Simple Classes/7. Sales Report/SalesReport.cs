using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                var currentSale = Sale.Parse(currentSaleAsString);

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown[currentSale.Town] = 0;
                }

                salesByTown[currentSale.Town] += currentSale.Quantity * currentSale.Price;
            }

            foreach (var townAndProfit in salesByTown)
            {
                Console.WriteLine($"{townAndProfit.Key} -> {townAndProfit.Value:F2}");
            }
        }       
    }
}
