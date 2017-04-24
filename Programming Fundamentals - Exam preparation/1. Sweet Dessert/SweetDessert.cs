using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.Sweet_Dessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            var ivanchoMoney = decimal.Parse(Console.ReadLine());
            var numberOfGuests = long.Parse(Console.ReadLine());
            var banannaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var portionSets = Math.Ceiling(numberOfGuests / 6m);

            decimal finalSum = (portionSets * (2 * banannaPrice)) + (portionSets * (4 * eggPrice)) + (portionSets * (0.2m * berriesPrice));
            
            if (ivanchoMoney >= finalSum)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {finalSum:f2}lv.");
            }
            else
            {
                decimal shortage = finalSum - ivanchoMoney;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {shortage:f2}lv more.");
            }
        }
    }
}
