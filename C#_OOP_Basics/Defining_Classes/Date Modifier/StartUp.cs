/*
Create a class DateModifier which stores the difference of the days between two Dates.It should have a method which 
takes two string parameters representing a date as strings and calculates the difference in the days between them. 
*/

using System;

namespace Date_Modifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstInputDate = Console.ReadLine();
            var secondInputDate = Console.ReadLine();

            Console.WriteLine(DateModifier.DifferenceBetweenTwoDates(firstInputDate, secondInputDate));
        }
    }
}
