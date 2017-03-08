using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Average_Student_Grades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            var students = int.Parse(Console.ReadLine());

            for (int i = 0; i < students; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var name = line[0];
                double grade = double.Parse(line[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }
            foreach (var nameAndGrade in grades)
            {
                var average = nameAndGrade.Value.Average();
                Console.WriteLine("{0} -> {1} (avg: {2:F2})",
                    nameAndGrade.Key, String.Join(" ", nameAndGrade.Value.Select(
                    p => String.Format("{0:F2}",p))), average);
            }
        }
    }
}
