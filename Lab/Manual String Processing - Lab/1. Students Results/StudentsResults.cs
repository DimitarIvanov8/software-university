using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Students_Results
{
/*
Write a program that reads number N from the console.After that read N lines
with students with their results in format { name} - {firstResult}, 
 {secondResult}, {thirdResult}
Print table on console.Each row must contain: 
•	CAdv - first result, align right with precision of 2
•	COOP - second result, align right with precision of 2
•	AdvOOP - third result, align right with precision of 2
•	Average – average result with precision of 4
•	Columns must be separated with "|"
•	Don't forget heading row 

Example input: 
1
Gosho - 3.33333, 4.4444, 5.555
*/
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
