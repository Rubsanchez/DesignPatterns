using DesignPatterns.FactoryMethod.Factories;

namespace DesignPatterns.FactoryMethod.Models
{
    public class FLPepperoniPizza : Pizza
    {
        public FLPepperoniPizza()
        {
            Type = PizzaType.Pepperoni;
            Dough = "Fine";
            Sauce = "Tomato sauce";
            Toppings.Add("Pepperoni");
        }
    }

    public class FLNeapolitanPizza : Pizza
    {
        public FLNeapolitanPizza()
        {
            Type = PizzaType.Neapolitan;
            Dough = "Fine";
            Sauce = "Tomato sauce";
            Toppings.Add("Mozzarella");
        }
    }

    public class FLCaliforniaPizza : Pizza
    {
        public FLCaliforniaPizza()
        {
            Type = PizzaType.California;
            Dough = "Fine";
            Sauce = "Tomato sauce";
            Toppings.Add("Mozzarella");
        }
    }
}
