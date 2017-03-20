using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale Parse(string currentSaleAsString)
        {
            var sale = currentSaleAsString
                .Split(' ');

            return new Sale
            {
                Town = sale[0],
                Product = sale[1],
                Price = decimal.Parse(sale[2]),
                Quantity = decimal.Parse(sale[3])
            };
        }
    }
}
