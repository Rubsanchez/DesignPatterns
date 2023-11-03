using DesignPatterns.FactoryMethod.Factories;

namespace DesignPatterns.FactoryMethod.Models
{
    public class NYPepperoniPizza : Pizza
    {
        public NYPepperoniPizza()
        {
            Type = PizzaType.Pepperoni;
            Dough = "Fine";
            Sauce = "Tomato sauce";
            Toppings.Add("Pepperoni");
        }
    }

    public class NYNeapolitanPizza : Pizza
    {
        public NYNeapolitanPizza()
        {
            Type = PizzaType.Neapolitan;
            Dough = "Fine";
            Sauce = "Tomato sauce";
            Toppings.Add("Mozzarella");
        }
    }

    public class NYCaliforniaPizza : Pizza
    {
        public NYCaliforniaPizza()
        {
            Type = PizzaType.California;
            Dough = "Fine";
            Sauce = "Tomato sauce";
            Toppings.Add("Mozzarella");
        }
    }
}
