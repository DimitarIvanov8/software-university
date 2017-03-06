using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();
            string line = Console.ReadLine();

            while (line != "shopping time")
            {
                var tokens = line.Split(' ');
                var currentProduct = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(currentProduct))
                {
                    products[currentProduct] = quantity;
                }
                else
                {
                    products[currentProduct] += quantity;
                }
                line = Console.ReadLine();
            }
            line = Console.ReadLine();

            while (line != "exam time")
            {
                var tokens = line.Split(' ');
                var currentProduct = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(currentProduct))
                {
                    Console.WriteLine($"{currentProduct} doesn't exist");
                }
                else
                {
                    if (products[currentProduct] == 0)
                    {
                        Console.WriteLine($"{currentProduct} out of stock");
                    }
                    else
                    {
                        products[currentProduct] -= quantity;

                        if (products[currentProduct] < 0)
                        {
                            products[currentProduct] = 0;
                        }
                    }

                }
                line = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> kvp in products)
            {
                var product = kvp.Key;
                var quantity = kvp.Value;

                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }
    }
}
