using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Day_of_Week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var someDate = Console.ReadLine();
            DateTime formatedDate = DateTime.ParseExact(
                someDate, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(formatedDate.DayOfWeek);
        }
    }
}
