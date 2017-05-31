using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AcademyGraduation
{
    class AcademyGraduation
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < number; i++)
            {
                var student = Console.ReadLine();
                var results = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => double.Parse(n, CultureInfo.InvariantCulture))
                    .ToList();

                students.Add(student, results);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
