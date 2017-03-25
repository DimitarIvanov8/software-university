using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__hard__Animals
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IQ { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    class Animals
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
            Dictionary<string, Cat> cats = new Dictionary<string, Cat>();
            Dictionary<string, Snake> snakes = new Dictionary<string, Snake>();
            
            var line = Console.ReadLine();

            while (line != "I'm your Huckleberry")
            {
                string[] inputParams = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!line.Contains("talk"))
                {
                    var currentClass = inputParams[0];
                    var currentName = inputParams[1];
                    var currentAge = int.Parse(inputParams[2]);
                    var currentParams = int.Parse(inputParams[3]);

                    if (currentClass == "Dog")
                    {
                        Dog newDog = new Dog
                        {
                            Name = currentName,
                            Age = currentAge,
                            NumberOfLegs = currentParams
                        };
                        dogs.Add(currentName, newDog);
                    }
                    else if (currentClass == "Cat")
                    {
                        Cat newCat = new Cat
                        {
                            Name = currentName,
                            Age = currentAge,
                            IQ = currentParams
                        };
                        cats.Add(currentName, newCat);
                    }
                    else if (currentClass == "Snake")
                    {
                        Snake newSnake = new Snake
                        {
                            Name = currentName,
                            Age = currentAge,
                            CrueltyCoefficient = currentParams
                        };
                        snakes.Add(currentName, newSnake);
                    }
                }
                else if (line.Contains("talk"))
                {
                    var currentAnimalName = inputParams[1];
                    if (dogs.ContainsKey(currentAnimalName))
                    {
                        Dog.ProduceSound();
                    }
                    else if (cats.ContainsKey(currentAnimalName))
                    {
                        Cat.ProduceSound();
                    }
                    else if (snakes.ContainsKey(currentAnimalName))
                    {
                        Snake.ProduceSound();
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IQ}");
            }
            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
