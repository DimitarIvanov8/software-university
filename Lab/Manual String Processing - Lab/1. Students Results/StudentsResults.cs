using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Students_Results
{
    class StudentsResults
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average");
            for (int i = 0; i < numberOfStudents; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] { ' ', '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0];
                var firstGrade = double.Parse(tokens[1]);
                var secondGrade = double.Parse(tokens[2]);
                var thirdGrade = double.Parse(tokens[3]);
                double averageGrade = (firstGrade + secondGrade + thirdGrade) / 3;

                Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", name, firstGrade, secondGrade, thirdGrade, averageGrade);
            }
        }
    }
}
