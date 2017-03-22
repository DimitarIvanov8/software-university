using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }

    class ExercisesMain
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();
            var inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                string[] inputParams = inputLine.Split(new[] { ',', '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = inputParams[0];
                var courseName = inputParams[1];
                var judgeContestLink = inputParams[2];

                List<string> problems = inputParams.Skip(3).ToList();

                Exercise newExercise = new Exercise
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeContestLink,
                    Problems = new List<string>(problems)
                };

                exercises.Add(newExercise);
                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);

                int count = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", count, problem);
                    count++;
                }
            }
        }
    }
}
