namespace p03_WildFarm.Models
{
    public abstract class Food
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; set; }
    }
}