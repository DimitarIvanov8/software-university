namespace p03_WildFarm.Models
{
    public abstract class Animal
    {
        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
        }

        protected string AnimalName { get; set; }

        protected string AnimalType { get; set; }

        protected double AnimalWeight { get; set; }

        protected int FoodEaten { get; set; }

        public abstract string MakeSound();

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
    }
}