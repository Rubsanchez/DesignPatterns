using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod.Models;
using NYPizzaStore = DesignPatterns.FactoryMethod.Factories.NYPizzaStore;

Console.WriteLine("Let's see design patterns");

var sandwich = CreateSandwich();
Console.WriteLine($"SANDWICH: {sandwich.Bread}, {sandwich.Cheese}, {sandwich.Condiments}, {sandwich.Protein}, {sandwich.Veggies}");

CreatePizza(PizzaType.Pepperoni);

CreateAbstractPizza();

#region Methods

Sandwich CreateSandwich()
{
    return new SandwichBuilder()
        .WithButterBread()
        .WithMeatProtein()
        .WithBBQCondiment()
        .Sandwich;
}

void CreatePizza(PizzaType type)
{
    new NYPizzaStore().OrderPizza(type);
}

void CreateAbstractPizza()
{
    DesignPatterns.AbstractFactory.Factories.PizzaStore nyStore = new DesignPatterns.AbstractFactory.Factories.NY.NYPizzaStore();
    DesignPatterns.AbstractFactory.Models.Pizzas.Pizza pizza = nyStore.OrderPizza(DesignPatterns.AbstractFactory.Models.Pizzas.PizzaType.Pepperoni);
    Console.WriteLine($"Pizza {pizza.Type} ready to be delivered to Rubén");

}

#endregion