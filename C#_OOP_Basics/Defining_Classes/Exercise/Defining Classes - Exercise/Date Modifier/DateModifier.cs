using System;
using System.Globalization;

namespace Date_Modifier
{
    class DateModifier
    {
        public static int DifferenceBetweenTwoDates(string date1, string date2)
        {
            DateTime firstDate = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);

            var difference = 0;
            if (firstDate >= secondDate)
            {
                difference = (firstDate - secondDate).Days;
            }
            else
            {
                difference = (secondDate - firstDate).Days;
            }

            return difference;
        }
    }
}
