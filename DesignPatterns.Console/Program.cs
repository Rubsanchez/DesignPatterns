using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod.Models;
using DesignPatterns.Serialization.Extensions;
using Category = DesignPatterns.PrototypeClone.Models.Category;
using NYPizzaStore = DesignPatterns.FactoryMethod.Factories.NYPizzaStore;
using Product = DesignPatterns.PrototypeClone.Models.Product;

Console.WriteLine("Let's see design patterns");

//var sandwich = CreateSandwich();
//Console.WriteLine($"SANDWICH: {sandwich.Bread}, {sandwich.Cheese}, {sandwich.Condiments}, {sandwich.Protein}, {sandwich.Veggies}");

//CreatePizza(PizzaType.Pepperoni);

//CreateAbstractPizza();

CreateProducts();
CreateProductsSerialization();

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

void CreateProducts()
{
    Product notebook = new("MacBook Pro", new Category("Computers"));
    Console.WriteLine(notebook);

    var iphone = notebook.DeepCopy();
    iphone.Name = "Iphone";
    iphone.Category!.Name = "Mobiles";
    Console.WriteLine(iphone);
}

void CreateProductsSerialization()
{

    DesignPatterns.Serialization.Models.Product notebook = new("MacBook Pro", new DesignPatterns.Serialization.Models.Category("Computers"));
    Console.WriteLine(notebook);

    var iphone = notebook.DeepCopy();
    iphone.Name = "Iphone";
    iphone.Category!.Name = "Mobiles";
    Console.WriteLine(iphone);
}
#endregion