namespace DesignPatterns.Builder
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich;
        public Sandwich Sandwich => _sandwich;

        public SandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public SandwichBuilder WithButterBread()
        {
            _sandwich.Bread = "Butter bread";
            return this;
        }

        public SandwichBuilder WithMeatProtein()
        {
            _sandwich.Protein = "Meat";
            return this;
        }

        public SandwichBuilder WithCheddarCheese()
        {
            _sandwich.Cheese = "Cheddar";
            return this;
        }

        public SandwichBuilder WithLettuceVeggies()
        {
            _sandwich.Veggies = "Lettuce";
            return this;
        }

        public SandwichBuilder WithBBQCondiment()
        {
            _sandwich.Condiments = "BBQ";
            return this;
        }
    }
}
