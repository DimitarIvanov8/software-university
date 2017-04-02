using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.JSON_stringify
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }

    class JSONstringify
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            var line = Console.ReadLine();

            while (line != "stringify")
            {
                var tokens = line.Split(new[] {' ', ',', ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0].Trim();
                int age = int.Parse(tokens[1].Trim());
                int[] grades = tokens.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();
                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Grades = grades;

                students.Add(newStudent);

                line = Console.ReadLine();
            }

            Console.Write("[");
            for (int i = 0; i < students.Count; i++)
            {
                Console.Write($"{{name:\"{students[i].Name}\",age:{students[i].Age},grades:[{String.Join(", ", students[i].Grades)}]}}");

                if (i == students.Count - 1)
                {
                    Console.WriteLine("]");
                }
                else
                {
                    Console.Write(",");
                }
            }
        }
    }
}
