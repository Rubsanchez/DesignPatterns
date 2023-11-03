using DesignPatterns.Adapter.Implementations;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod.Models;
using DesignPatterns.Serialization.Extensions;
using DesignPatterns.Singleton.Implementations;
using Category = DesignPatterns.PrototypeClone.Models.Category;
using NYPizzaStore = DesignPatterns.FactoryMethod.Factories.NYPizzaStore;
using Product = DesignPatterns.PrototypeClone.Models.Product;

Console.WriteLine("Let's see design patterns\n");

//var sandwich = CreateSandwich();
//Console.WriteLine($"SANDWICH: {sandwich.Bread}, {sandwich.Cheese}, {sandwich.Condiments}, {sandwich.Protein}, {sandwich.Veggies}");

//CreatePizza(PizzaType.Pepperoni);
//CreateAbstractPizza();

//CreateProducts();
//CreateProductsSerialization();

//SingletonPattern();

CreateProductsAdapter();

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

void SingletonPattern()
{
    var capitals = SingletonDataContainer.Instance;
    var capitals1 = SingletonDataContainer.Instance;
    var capitals2 = SingletonDataContainer.Instance;
    var capitals3 = SingletonDataContainer.Instance;

    Console.WriteLine($"London population is {capitals.GetPopulation("London")}");
}

void CreateProductsAdapter()
{
    var xmlConverter = new XmlConverter();
    var adapter = new XmlToJsonAdapter(xmlConverter);
    adapter.ConvertXmlToJson();
}
#endregion